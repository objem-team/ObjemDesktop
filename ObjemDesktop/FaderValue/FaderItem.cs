using ObjemDesktop.VolumeManaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop.window
{
    public class FaderItem:IEquatable<FaderItem>
    {
        public IVolumeController VolumeController { get; protected set; }
        public int Index { get; protected set; }
        public FaderItem(IVolumeController volumeController,int index)
        {
            VolumeController = volumeController;
            Index = index;

        }

        public bool Equals(FaderItem other)
        {
            return VolumeController.ProcessId == other.VolumeController.ProcessId;
        }
    }
}
