using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;

namespace ObjemDesktop
{
    class QrPair
    {

        public IPAddress ipaddress { get; set; }
        public Image qrcode { get; set; }
        public QrPair(IPAddress ipaddress, Image qrcode)
        {
            this.ipaddress = ipaddress;
            this.qrcode = qrcode;
        }
    }
}
