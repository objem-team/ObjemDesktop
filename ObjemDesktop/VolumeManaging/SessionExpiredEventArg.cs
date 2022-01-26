namespace ObjemDesktop.VolumeManaging
{
    public class SessionExpiredEventArg
    {
        public readonly IVolumeController VolumeController;
        public SessionExpiredEventArg(IVolumeController volumeController)
        {
            VolumeController = volumeController;
        }
    }
}