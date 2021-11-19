using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop
{
    class IpAddress
    {
        public static List<IPAddress> IpAdress()
        {
            //IPアドレス取得
            String hostname = Dns.GetHostName();
            String ip = String.Empty;

            IPAddress[] Addresess = Dns.GetHostAddresses(hostname);
            List<IPAddress> AddressList = Addresess.Where(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList();
            return AddressList;
        }
    }
}
