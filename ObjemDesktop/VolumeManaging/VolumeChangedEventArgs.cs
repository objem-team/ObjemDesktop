namespace ObjemDesktop.VolumeManaging
{
    public class VolumeChangedEventArgs
    {
        public float NewVolume { get; }
        public bool IsMuted { get; }

        public IVolumeController VolumeController;
        public VolumeChangedEventArgs(IVolumeController volumeController, float NewVolume, bool IsMuted)
        {
            this.VolumeController = volumeController;
            this.NewVolume = NewVolume;
            this.IsMuted = IsMuted;
        }
    }
}