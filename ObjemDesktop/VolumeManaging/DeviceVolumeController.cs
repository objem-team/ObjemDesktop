using CSCore.CoreAudioAPI;
using CSCore.Win32;
using System;
using System.Drawing;
using System.Security.Cryptography;

namespace ObjemDesktop.VolumeManaging
{
    class DeviceVolumeController : IVolumeController, IDisposable
    {
        public MMDevice Device;
        AudioEndpointVolume AudioEndpointVolume;

        public event EventHandler<VolumeChangedEventArgs> VolumeChanged;


        //プロセスIDをマイナスを利用する。
        public int ProcessId { get; }
        public string Name { get; }
        public Icon Icon { get; }

        public float Volume {
            get 
            {
                return AudioEndpointVolume.MasterVolumeLevelScalar;
            }
        }
        public bool IsMuted
        {
            get
            {
                return AudioEndpointVolume.IsMuted;
            }
        }
        public DeviceVolumeController(MMDevice device)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                /*
                 * sessionとかぶることのないマイナス値をIDに用いる
                 * デバイスidの文字列をbyteに変換し最後の4bitを用いてintに変換する
                 */
                byte[] deviceID = System.Text.Encoding.UTF8.GetBytes(device.DeviceID);
                int processID = BitConverter.ToInt32(deviceID,deviceID.Length-4);
                ProcessId = processID*-1;
                Device = device;
                AudioEndpointVolume = AudioEndpointVolume.FromDevice(Device);
                Name = Device.FriendlyName;
                using (var PropertyStore = Device.PropertyStore)
                {
                    //Iconを取得する
                    PropertyKey key = new PropertyKey(Guid.Parse("259abffc-50a7-47ce-af08-68c9a7d73366"), 12);
                    string[] results = PropertyStore.GetValue(key).ToString().Split(',');
                    string path = results[0].Trim().Trim('@');
                    int index = Int32.Parse(results[1]);
                    //pathからアイコンを取得する
                    Icon = IconExtracter.Extract(path, index);
                }
                AudioEndpointVolumeCallback callback = new AudioEndpointVolumeCallback();
                callback.NotifyRecived += (sender, arg) => VolumeChanged?.Invoke(sender, new VolumeChangedEventArgs(this, arg.MasterVolume, arg.IsMuted));
                AudioEndpointVolume.RegisterControlChangeNotify(callback);
            }

        }

        public void SetVolume(float newVolume,bool isMute)
        {
            AudioEndpointVolume.MasterVolumeLevelScalar = newVolume;
            AudioEndpointVolume.IsMuted = isMute;
        }

        public void Dispose()
        {
            Device.Dispose();
            AudioEndpointVolume.Dispose();
        }

        public bool Equals(IVolumeController other)
        {
            return (ProcessId == other.ProcessId);
        }
    }
}