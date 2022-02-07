using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop.window
{
    class SerialSendObject
    {
        OmfEvents Event { get; }
        byte FaderNumber { get; }
        string Value { get; }

        public SerialSendObject(OmfEvents omfEvent, byte faderNumber, string value)
        {
            Event = omfEvent;
            FaderNumber = faderNumber;
            Value = value;
        }

        public override string ToString()
        {
            return $"{(int) Event}:{FaderNumber}:{Value}:";
        }
    }
}