namespace ObjemDesktop.WebsocketMessageType
{
    class VolumeChangeRequest
    {
        public int ProcessId { get; }
        public float Volume { get; }
        public bool IsMuted { get; }

        public VolumeChangeRequest(int processId,float volume,bool isMuted)
        {
            ProcessId = processId;
            Volume = volume;
            IsMuted = isMuted;
        }
    }
}
