using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;
using ObjemDesktop.Properties;


namespace ObjemDesktop.VolumeManaging
{
    class VolumeManager
    {
        public static readonly VolumeManager Instance = new VolumeManager();

        //DeviceのStatusを監視させるための
        //AudioSessionNotificationを継承するクラスを作ってセッションの作成を監視

        public readonly List<IVolumeController> List = new List<IVolumeController>();

        public event EventHandler<VolumeChangedEventArgs> OnVolumeChange;
        public event EventHandler<SessionExpiredEventArg> OnSessionExpired;
        public event EventHandler<SessionCreatedEventArgs> OnSessionCreated;
        public event EventHandler<DefaultDeviceChangedEventArgs> OnDefaultDeviceChanged;

        private VolumeManager()
        {
            //デフォルトのマイクとスピーカーを取得
            var deviceEnumerator = new MMDeviceEnumerator();
            MMDevice defaultRenderDevice = null;
            MMDevice defaultCaptureDevice = null;
            try
            {
                defaultRenderDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                defaultCaptureDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);
            }
            catch (Exception)
            {
                //ignore
            }


            //デバイス音量が変更されたときのイベントを登録
            if (defaultRenderDevice != null)
            {
                DeviceVolumeController renderDeviceVolumeContoroller = new DeviceVolumeController(defaultRenderDevice);
                renderDeviceVolumeContoroller.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
                List.Add(renderDeviceVolumeContoroller);
            }

            if (defaultCaptureDevice != null)
            {
                DeviceVolumeController caputureDeviceVolumeContoroller =
                    new DeviceVolumeController(defaultCaptureDevice);
                caputureDeviceVolumeContoroller.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
                List.Add(caputureDeviceVolumeContoroller);
            }

            //デフォルトのデバイスが変更されたときのイベントを登録
            MMNotificationClient notificationClient = new MMNotificationClient();
            notificationClient.DefaultDeviceChanged +=
                (sender, eventArgs) => OnDefaultDeviceChanged?.Invoke(sender, eventArgs);
            deviceEnumerator.RegisterEndpointNotificationCallback(notificationClient);

            //セッションの追加を監視
            if (defaultRenderDevice is null) return;
            var audioSessionManager = AudioSessionManager2.FromMMDevice(defaultRenderDevice);
            AudioSessionNotification audioSessionNotification = new AudioSessionNotification();
            audioSessionNotification.SessionCreated += (sender, eventArgs) =>
            {
                OnSessionCreated?.Invoke(sender, eventArgs);
                audioSessionManager.GetSessionEnumerator();
                //おまじない   https://github.com/filoe/cscore/issues/216
                //カウンタを意図的にリセットする。
                //using (var sessionEnumerator = AudioSessionManager.GetSessionEnumerator()) { }
            };
            audioSessionManager.RegisterSessionNotification(audioSessionNotification);


            //sessionの音量が変更されたときのイベントを登録
            AudioSessionEnumerator audioSessionEnumerator = audioSessionManager.GetSessionEnumerator();
            foreach (var session in audioSessionEnumerator)
            {
                try
                {
                    AddSession(session);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void RegisterEvent(SessionVolumeController sessionVolumeController)
        {
            sessionVolumeController.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
            sessionVolumeController.SessionExpired += (sender, arg) => OnSessionExpired?.Invoke(sender, arg);
        }

        public void AddSession(AudioSessionControl session)
        {
            try
            {
                var simpleVolume = session.QueryInterface<SimpleAudioVolume>();
                var sessionControl = session.QueryInterface<AudioSessionControl2>();
                if (Settings.Default.DisabledProcess != null)
                {
                    if (sessionControl.Process.MainModule != null &&
                        sessionControl.Process != null &&
                        Settings.Default.DisabledProcess.Contains(sessionControl.Process.MainModule.FileName)
                       ) return;
                }

                //すでに存在する場合追加しない
                if (List.FindIndex(s => s.ProcessId == sessionControl.ProcessID) >= 0) return;
                SessionVolumeController sessionVolumeController =
                    new SessionVolumeController(sessionControl, simpleVolume);
                RegisterEvent(sessionVolumeController);
                List.Add(sessionVolumeController);
            }
            catch (Exception)
            {
                //ignore
            }
        }

        public void SetVolume(int processId, float volume, bool isMute)
        {
            List.Find(x => x.ProcessId == processId).SetVolume(volume, isMute);
        }
    }
}