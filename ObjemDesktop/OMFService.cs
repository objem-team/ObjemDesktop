using System;
using System.Diagnostics;
using System.IO.Ports;
using ObjemDesktop.FaderValue;
using ObjemDesktop.VolumeManaging;

namespace ObjemDesktop.window
{
    class OMFService
    {
        private FaderItems items;
        private SerialPort _serialPort;
        private ForegroundHandler handler;

        public OMFService()
        {
            var volumeManager = VolumeManager.Instance;
            handler = new ForegroundHandler();
            handler.ForegroundWindowChange += OnWindowChange;
            items = new FaderItems();
            items.Item0 = new FaderItem(volumeManager.List[0], 0);
            items.Item1 = new FaderItem(volumeManager.List[1], 1);
            items.OnChangeItems += OnItemsChange;

            _serialPort = getObjemSerialPort();
            if (_serialPort is null)
            {
                //USBの状態を監視して都度確認する
                return;
            }

            volumeManager.OnVolumeChange += OnVolumeChange;
            _serialPort.DataReceived += DatarecievedHandler;
        }

        private void DatarecievedHandler(object sender, SerialDataReceivedEventArgs eventArgs)
        {
            var serialPort = (SerialPort) sender;
            var data = serialPort.ReadLine();
            //処理書く
        }

        private void OnVolumeChange(object sender, VolumeChangedEventArgs arg)
        {
            if (!_serialPort.IsOpen) return;
            if (arg.VolumeController.ProcessId == items.Item0.VolumeController.ProcessId)
            {
                //Fader0に送る
                _serialPort.WriteLine(new SerialSendObject(1, 0, arg.NewVolume.ToString()).ToString());
            }
            else if (arg.VolumeController.ProcessId == items.Item1.VolumeController.ProcessId)
            {
                //fader1に送る
                _serialPort.WriteLine(new SerialSendObject(1, 1, arg.NewVolume.ToString()).ToString());
            }
        }

        private void OnWindowChange(object sender, Process process)
        {
            var found = VolumeManager.Instance.List.FindIndex(controller => controller.ProcessId == process.Id);
            FaderItem newItem = null;
            if (found < 0)
            {
                newItem = new FaderItem(VolumeManager.Instance.List[0], 0);
            }
            else
            {
                newItem = new FaderItem(VolumeManager.Instance.List[found], found);
            }

            if (!items.Item1.Equals( newItem))
            {
                items.Item1 = newItem;
            }
        }

        private void OnItemsChange(object sender, FaderItemChangeEventArg arg)
        {
            if (arg.Item is null) return;
            if (_serialPort is null || !(_serialPort.IsOpen)) return;
            //表示
            _serialPort.WriteLine(new SerialSendObject(1, 0, arg.Item.VolumeController.Name).ToString());
            //音量
            _serialPort.WriteLine(new SerialSendObject(1, 0, Math.Round(arg.Item.VolumeController.Volume, 1).ToString()).ToString());
        }

        static SerialPort getObjemSerialPort()
        {
            foreach (var name in SerialPort.GetPortNames())
            {
                var serialPort = new SerialPort(name);
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.WriteTimeout = 1000; //ms
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = true;
                try
                {
                    serialPort.Open();
                    serialPort.WriteLine("");
                }
                catch (Exception)
                {
                    continue;
                }

                return serialPort;
            }

            return null;
        }
    }
}