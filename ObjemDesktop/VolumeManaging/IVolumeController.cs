using System;
using System.Drawing;
namespace ObjemDesktop.VolumeManaging
{
    public interface IVolumeController : IEquatable<IVolumeController>
    {
        event EventHandler<VolumeChangedEventArgs> VolumeChanged;
        int ProcessId { get; }
        string Name { get; }
        Icon Icon { get; }
        float Volume { get; }
        bool IsMuted { get; }
        void SetVolume(float newVolume,bool isMute);
    }
}