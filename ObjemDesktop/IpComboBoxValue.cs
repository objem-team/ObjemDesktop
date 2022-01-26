using System.Net;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ObjemDesktop
{
    class IpComboBoxValue
    {
        public IPAddress IpAddress { get; }
        public Image QrCode { get; }
        public X509Certificate2 Certificate;
        public IpComboBoxValue(IPAddress ipaddress, Image qrcode,X509Certificate2 cert)
        {
            IpAddress = ipaddress;
            QrCode = qrcode;
            Certificate = cert;
        }
    }
}
