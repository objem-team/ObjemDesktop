using System.Net;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop
{
    class IPConboBoxValue
    {

        public IPAddress IPAddress { get; set; }
        public Image QRCode { get; set; }
        public X509Certificate2 Certificate;
        public IPConboBoxValue(IPAddress ipaddress, Image qrcode,X509Certificate2 cert)
        {
            this.IPAddress = ipaddress;
            this.QRCode = qrcode;
            this.Certificate = cert;
        }
    }
}
