using CSCore.CoreAudioAPI;
using System;
using System.Diagnostics;
using System.Drawing;
namespace ObjemDesktop.VolumeManaging
{
    internal class SessionVolumeController:IVolumeController
    {
        private AudioSessionControl2 AudioSessionControl { get; }
        private SimpleAudioVolume SimpleAudioVolume { get; }
        public int ProcessId { get; }
        public string Name { get; }
        public Icon Icon { get; }

        public float Volume => SimpleAudioVolume.MasterVolume;

        public bool IsMuted => SimpleAudioVolume.IsMuted;

        public event EventHandler<VolumeChangedEventArgs> VolumeChanged;
        public event EventHandler<SessionExpiredEventArg> SessionExpired;

        public SessionVolumeController(AudioSessionControl2 audioSessionControl, SimpleAudioVolume simpleAudioVolume)
        {
            AudioSessionControl = audioSessionControl;
            SimpleAudioVolume = simpleAudioVolume;
            Process process = Process.GetProcessById(audioSessionControl.ProcessID);
            ProcessId = audioSessionControl.ProcessID;
            Name = process.ProcessName;
            Icon = GetIcon(audioSessionControl);
            //音量に変更があったとき
            AudioSessionControl.SimpleVolumeChanged += (sender, arg) => VolumeChanged?.Invoke(sender, new VolumeChangedEventArgs(this, arg.NewVolume, arg.IsMuted));
            //session が切れたとき
            audioSessionControl.StateChanged += OnSessionStateChanged;
        }



        public void SetVolume(float newVolume,bool isMute)
        {
            SimpleAudioVolume.MasterVolume = newVolume;
            SimpleAudioVolume.IsMuted = isMute;
        }


        private Icon GetIcon(AudioSessionControl2 audioSessionControl)
        {
            if (audioSessionControl.IconPath != string.Empty)
            {
                var pathWhithIndex = audioSessionControl.IconPath.Split(',');
                if (pathWhithIndex.Length != 2) { return null; }
                var path = pathWhithIndex[0];
                Console.WriteLine(path);
                var index = Int32.Parse(pathWhithIndex[1]);
                path = path.Trim('@');
                return IconExtracter.Extract(path, index);
            }
            try
            {
                if (audioSessionControl.Process.MainModule != null)
                    return Icon.ExtractAssociatedIcon(audioSessionControl.Process.MainModule.FileName);
                return IconExtracter.GetDefaultIcon();
            }
            catch (Exception)
            {
                return IconExtracter.GetDefaultIcon();
            }
        }

        private void OnSessionStateChanged(object sender, AudioSessionStateChangedEventArgs eventArgs)
        {
            
            if (eventArgs.NewState == AudioSessionState.AudioSessionStateExpired)
            {
                Console.WriteLine("Expire");
                SessionExpired?.Invoke(sender, new SessionExpiredEventArg(this));
            }
        }
        public void Dispose()
        {
            this.AudioSessionControl.Dispose();
            this.SimpleAudioVolume.Dispose();
        }

        public bool Equals(IVolumeController other)
        {
            return other != null && (ProcessId == other.ProcessId);
        }
    }
}