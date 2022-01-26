using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;


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
            var defaultRenderDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            var defaultCaptureDevice = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);


            //デバイス音量が変更されたときのイベントを登録
            DeviceVolumeController renderDeviceVolumeContoroller = new DeviceVolumeController(defaultRenderDevice);
            renderDeviceVolumeContoroller.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
            List.Add(renderDeviceVolumeContoroller);

            DeviceVolumeController caputureDeviceVolumeContoroller = new DeviceVolumeController(defaultCaptureDevice);
            caputureDeviceVolumeContoroller.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
            List.Add(caputureDeviceVolumeContoroller);

            //デフォルトのデバイスが変更されたときのイベントを登録
            MMNotificationClient notificationClient = new MMNotificationClient();
            notificationClient.DefaultDeviceChanged += (sender, eventArgs) => OnDefaultDeviceChanged?.Invoke(sender, eventArgs);
            deviceEnumerator.RegisterEndpointNotificationCallback(notificationClient);

            //セッションの追加を監視
            var audioSessionManager = AudioSessionManager2.FromMMDevice(defaultRenderDevice);
            AudioSessionNotification audioSessionNotification = new AudioSessionNotification();
            audioSessionNotification.SessionCreated += (sender, eventArgs) => OnSessionCreated?.Invoke(sender, eventArgs);
            audioSessionManager.RegisterSessionNotification(audioSessionNotification);

            //おまじない   https://github.com/filoe/cscore/issues/216
            //using (var sessionEnumerator = AudioSessionManager.GetSessionEnumerator()) { }

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
            var simpleVolume = session.QueryInterface<SimpleAudioVolume>();
            var sessionControl = session.QueryInterface<AudioSessionControl2>();
            SessionVolumeController sessionVolumeController = new SessionVolumeController(sessionControl, simpleVolume);
            RegisterEvent(sessionVolumeController);
            List.Add(sessionVolumeController);
        }

        public void SetVolume(int processId,float volume,bool isMute)
        {
            List.Find(x => x.ProcessId == processId).SetVolume(volume,isMute);
        }
    }

}
