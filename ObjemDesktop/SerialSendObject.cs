using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop.window
{
    class SerialSendObject
    {
        byte Event { get; set; }
        byte FaderNumber { get; set; }
        string Value { get; set; }

        public SerialSendObject(byte eventNumber, byte faderNumber, string value)
        {
            Event = eventNumber;
            FaderNumber = faderNumber;
            Value = value;
        }
        public override string ToString()
        {
            return $"{Event}:{FaderNumber}:{Value}:";
        }
    }

}
