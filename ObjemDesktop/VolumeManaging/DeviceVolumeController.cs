using CSCore.CoreAudioAPI;
using CSCore.Win32;
using System;
using System.Drawing;

namespace ObjemDesktop.VolumeManaging
{
    internal class DeviceVolumeController : IVolumeController, IDisposable
    {
        private readonly MMDevice _device;
        private readonly AudioEndpointVolume _audioEndpointVolume;

        public event EventHandler<VolumeChangedEventArgs> VolumeChanged;


        //プロセスIDをマイナスを利用する。
        public int ProcessId { get; }
        public string Name { get; }
        public Icon Icon { get; }

        public float Volume => _audioEndpointVolume.MasterVolumeLevelScalar;

        public bool IsMuted => _audioEndpointVolume.IsMuted;

        public DeviceVolumeController(MMDevice device)
        {
            /*
             * sessionとかぶることのないマイナス値をIDに用いる
             * デバイスidの文字列をbyteに変換し最後の4bitを用いてintに変換する
             */
            var deviceId = System.Text.Encoding.UTF8.GetBytes(device.DeviceID);
            var processId = BitConverter.ToInt32(deviceId, deviceId.Length - 4);
            ProcessId = processId * -1;
            _device = device;
            _audioEndpointVolume = AudioEndpointVolume.FromDevice(_device);
            Name = _device.FriendlyName;
            using (var propertyStore = _device.PropertyStore)
            {
                //Iconを取得する
                var key = new PropertyKey(Guid.Parse("259abffc-50a7-47ce-af08-68c9a7d73366"), 12);
                var results = propertyStore.GetValue(key).ToString().Split(',');
                var path = results[0].Trim().Trim('@');
                var index = Int32.Parse(results[1]);
                //pathからアイコンを取得する
                Icon = IconExtracter.Extract(path, index);
            }

            AudioEndpointVolumeCallback callback = new AudioEndpointVolumeCallback();
            callback.NotifyRecived += (sender, arg) =>
                VolumeChanged?.Invoke(sender, new VolumeChangedEventArgs(this, arg.MasterVolume, arg.IsMuted));
            _audioEndpointVolume.RegisterControlChangeNotify(callback);
        }

        public void SetVolume(float newVolume, bool isMute)
        {
            _audioEndpointVolume.MasterVolumeLevelScalar = newVolume;
            _audioEndpointVolume.IsMuted = isMute;
        }

        public void Dispose()
        {
            _device.Dispose();
            _audioEndpointVolume.Dispose();
        }

        public bool Equals(IVolumeController other)
        {
            return other != null && (ProcessId == other.ProcessId);
        }
    }
}