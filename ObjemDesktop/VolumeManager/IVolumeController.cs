using System;
using System.Drawing;
namespace ObjemDesktop.VolumeManager
{
    public interface IVolumeController
    {
        event EventHandler<VolumeChangedEventArgs> VolumeChanged;
        int ProcessId { get; }
        string Name { get; }
        Icon Icon { get; }
        void SetVolume(float newVolume);
    }
}