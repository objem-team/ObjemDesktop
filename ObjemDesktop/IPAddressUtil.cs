using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjemDesktop
{
    class IPAddressUtil
    {
        public static List<IPAddress> getIPAdressList()
        {
            //IPアドレス取得
            string hostname = Dns.GetHostName();
            string ip = string.Empty;
            IPAddress[] Addresess = Dns.GetHostAddresses(hostname);
            List<IPAddress> AddressList = Addresess.Where(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList();
            return AddressList;
        }
    }
}
