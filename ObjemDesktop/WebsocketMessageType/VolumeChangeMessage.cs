namespace ObjemDesktop.WebsocketMessageType
{
    class VolumeChangeMessage
    {
        public int ProcessId { get; }
        public float Volume { get; }
        public bool IsMuted { get; }

        public VolumeChangeMessage(int processId, float volume, bool isMuted)
        {
            ProcessId = processId;
            Volume = volume;
            IsMuted = isMuted;
        }
    }
}
