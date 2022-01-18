using CSCore.CoreAudioAPI;
using System;
using System.Collections.Generic;


namespace ObjemDesktop.VolumeManaging
{
    class VolumeManager
    {
        public static VolumeManager Instance = new VolumeManager();

        //DeviceのStatusを監視させるための
        private readonly MMDeviceEnumerator DeviceEnumerator;
        //AudioSessionNotificationを継承するクラスを作ってセッションの作成を監視
        private readonly AudioSessionManager2 AudioSessionManager;

        public List<IVolumeController> list = new List<IVolumeController>();

        public MMDevice DefaultRenderDevice;
        public MMDevice DefaultCaptureDevice;

        public event EventHandler<VolumeChangedEventArgs> OnVolumeChange;
        public event EventHandler<SessionExpiredEventArg> OnSessionExpired;
        public event EventHandler<SessionCreatedEventArgs> OnSessionCreated;
        public event EventHandler<DefaultDeviceChangedEventArgs> OnDefaultDeviceChanged;

        private VolumeManager()
        {
            //デフォルトのマイクとスピーカーを取得
            DeviceEnumerator = new MMDeviceEnumerator();
            DefaultRenderDevice = DeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            DefaultCaptureDevice = DeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Multimedia);


            //デバイス音量が変更されたときのイベントを登録
            DeviceVolumeController RenderDeviceVolumeContoroller = new DeviceVolumeController(DefaultRenderDevice);
            RenderDeviceVolumeContoroller.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
            list.Add(RenderDeviceVolumeContoroller);

            DeviceVolumeController CaputureDeviceVolumeContoroller = new DeviceVolumeController(DefaultCaptureDevice);
            CaputureDeviceVolumeContoroller.VolumeChanged += (sender, arg) => OnVolumeChange?.Invoke(sender, arg);
            list.Add(CaputureDeviceVolumeContoroller);

            //デフォルトのデバイスが変更されたときのイベントを登録
            MMNotificationClient notificationClient = new MMNotificationClient();
            notificationClient.DefaultDeviceChanged += (object sender, DefaultDeviceChangedEventArgs eventArgs) => OnDefaultDeviceChanged?.Invoke(sender, eventArgs);
            DeviceEnumerator.RegisterEndpointNotificationCallback(notificationClient);

            //セッションの追加を監視
            AudioSessionManager = AudioSessionManager2.FromMMDevice(DefaultRenderDevice);
            AudioSessionNotification audioSessionNotification = new AudioSessionNotification();
            audioSessionNotification.SessionCreated += (object sender, SessionCreatedEventArgs eventArgs) => OnSessionCreated?.Invoke(sender, eventArgs);
            AudioSessionManager.RegisterSessionNotification(audioSessionNotification);

            //おまじない   https://github.com/filoe/cscore/issues/216
            //using (var sessionEnumerator = AudioSessionManager.GetSessionEnumerator()) { }

            //sessionの音量が変更されたときのイベントを登録
            AudioSessionEnumerator AudioSessionEnumerator = AudioSessionManager.GetSessionEnumerator();
            foreach (var session in AudioSessionEnumerator)
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
            list.Add(sessionVolumeController);
        }

        public void SetVolume(int processId,float volume,bool isMute)
        {
            list.Find(x => x.ProcessId == processId).SetVolume(volume,isMute);
        }
    }

}
