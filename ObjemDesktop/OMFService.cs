using System;
using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
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

            _serialPort = GetObjemSerialPort();
            if (_serialPort is null)
            {
                //USBの状態を監視して都度確認する
                return;
            }

            volumeManager.OnVolumeChange += OnVolumeChange;
            _serialPort.DataReceived += DatarecievedHandler;


            items = new FaderItems();
            items.OnChangeItems += OnItemsChange;
            items.Item0 = new FaderItem(volumeManager.List[0], 0);
            items.Item1 = new FaderItem(volumeManager.List[1], 1);
        }

        private void DatarecievedHandler(object sender, SerialDataReceivedEventArgs eventArgs)
        {
            var serialPort = (SerialPort) sender;
            var data = serialPort.ReadLine();
            Console.WriteLine("Resive : " + data.Trim());
            switch (data.Trim())
            {
                case "next":
                {
                    int newIndex = items.Item1.Index + 1;
                    var sessionList = VolumeManager.Instance.List;
                    if (newIndex >= sessionList.Count)
                    {
                        newIndex = 0;
                    }

                    items.Item1 = new FaderItem(VolumeManager.Instance.List[newIndex], newIndex);
                    break;
                }

                case "prev":
                {
                    int newIndex = items.Item1.Index - 1;
                    var sessionList = VolumeManager.Instance.List;
                    if (newIndex < 0)
                    {
                        newIndex = sessionList.Count - 1;
                    }

                    items.Item1 = new FaderItem(VolumeManager.Instance.List[newIndex], newIndex);
                    break;
                }
            }
        }

        private void OnVolumeChange(object sender, VolumeChangedEventArgs arg)
        {
            try
            {
                if (!_serialPort.IsOpen) return;
                if (arg.VolumeController.ProcessId == items.Item0.VolumeController.ProcessId)
                {
                    //Fader0に送る
                    _serialPort.WriteLine(new SerialSendObject(OmfEvents.VolumeEvent, 0, arg.NewVolume.ToString())
                        .ToString());
                }
                else if (arg.VolumeController.ProcessId == items.Item1.VolumeController.ProcessId)
                {
                    //fader1に送る
                    _serialPort.WriteLine(new SerialSendObject(OmfEvents.VolumeEvent, 1, arg.NewVolume.ToString())
                        .ToString());
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        private void OnWindowChange(object sender, Process process)
        {
            var found = VolumeManager.Instance.List.FindIndex(s => s.ProcessId == process.Id);
            if (found < 0)
            {
                found = VolumeManager.Instance.List.FindIndex(s =>
                {
                    try
                    {
                        if (s.ProcessId < 0) return false;
                        var pr = Process.GetProcessById(s.ProcessId);
                        return pr.MainModule.FileName.Equals(process.MainModule.FileName);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                });
            }

            FaderItem newItem = null;
            if (found < 0)
            {
                newItem = new FaderItem(VolumeManager.Instance.List[0], 0);
            }
            else
            {
                newItem = new FaderItem(VolumeManager.Instance.List[found], found);
            }

            if (items != null && !items.Item0.Equals(newItem))
            {
                items.Item0 = newItem;
            }
        }

        private void OnItemsChange(object sender, FaderItemChangeEventArg arg)
        {
            try
            {
                if (arg.Item is null) return;
                if (_serialPort is null || !(_serialPort.IsOpen)) return;

                //表示
                Console.WriteLine("Send : " +
                                  new SerialSendObject(OmfEvents.Display, (byte) arg.FaderNumber,
                                          arg.Item.VolumeController.Name)
                                      .ToString());
                _serialPort.WriteLine(
                    new SerialSendObject(OmfEvents.Display, (byte) arg.FaderNumber, arg.Item.VolumeController.Name)
                        .ToString());
                //音量
                _serialPort.WriteLine(new SerialSendObject(OmfEvents.VolumeEvent, 0,
                        Math.Round(arg.Item.VolumeController.Volume * 100, 1).ToString(CultureInfo.InvariantCulture))
                    .ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        void SaftySend(String data)
        {
        }

        private static SerialPort GetObjemSerialPort()
        {
            foreach (var name in SerialPort.GetPortNames())
            {
                Console.WriteLine(name);
                var serialPort = new SerialPort(name);
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.WriteTimeout = 100; //ms
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.RtsEnable = true;
                try
                {
                    serialPort.Open();
                    serialPort.WriteLine("Hello Objem");
                }
                catch (Exception)
                {
                    continue;
                }

                return serialPort;
            }

            Console.WriteLine("None");
            return null;
        }
    }
}