using ObjemDesktop.window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop
{
    public class FaderItemChangeEventArg : EventArgs
    {
        public int FaderNumber { get; }
        public FaderItem Item { get; }

        public FaderItemChangeEventArg(int faderNumber, FaderItem item)
        {
            FaderNumber = faderNumber;
            Item = item;
        }
    }
}