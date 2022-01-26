using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace ObjemDesktop
{
    class IPAddressUtil
    {
        public static List<IPAddress> GetIpAdressList()
        {
            //IPアドレス取得
            var hostname = Dns.GetHostName();
            var ip = string.Empty;
            IPAddress[] addresess = Dns.GetHostAddresses(hostname);
            List<IPAddress> addressList = addresess.Where(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList();
            return addressList;
        }
    }
}
