namespace ObjemDesktop.VolumeManaging
{
    public class SessionExpiredEventArg
    {
        public IVolumeController VolumeController;
        public SessionExpiredEventArg(IVolumeController VolumeController)
        {
            this.VolumeController = VolumeController;
        }
    }
}