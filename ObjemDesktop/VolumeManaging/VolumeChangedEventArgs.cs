namespace ObjemDesktop.VolumeManaging
{
    public class VolumeChangedEventArgs
    {
        public float NewVolume { get; }
        public bool IsMuted { get; }

        public readonly IVolumeController VolumeController;
        public VolumeChangedEventArgs(IVolumeController volumeController, float newVolume, bool isMuted)
        {
            this.VolumeController = volumeController;
            this.NewVolume = newVolume;
            this.IsMuted = isMuted;
        }
    }
}