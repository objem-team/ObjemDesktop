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
        int FaderNumber { get; }
        string Value { get; }

        public SerialSendObject(OmfEvents omfEvent, int faderNumber, string value)
        {
            Event = omfEvent;
            FaderNumber = faderNumber;
            Value = value;
        }
        
        public SerialSendObject(OmfEvents omfEvent, int faderNumber, float value):this(omfEvent,faderNumber,((int)value).ToString())
        {
        }
        

        public override string ToString()
        {
            
            //return $"{(int)Event * 10 + FaderNumber}:{Value}:";
            return $"{(int) Event}:{FaderNumber}:{Value}:";
        }
    }
}