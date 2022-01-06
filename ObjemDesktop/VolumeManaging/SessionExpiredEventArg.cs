namespace ObjemDesktop.VolumeManaging
{
    public class SessionExpiredEventArg
    {
        IVolumeController VolumeController;
        public SessionExpiredEventArg(IVolumeController VolumeController)
        {
            this.VolumeController = VolumeController;
        }
    }
}