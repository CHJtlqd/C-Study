using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAdress = IPAddress.Parse("192.168.0.120");
            Console.WriteLine(ipAdress);

            IPAddress ipAddr2 = new IPAddress(new byte[] { 202, 179, 177, 21 });
            Console.WriteLine(ipAddr2);

            IPHostEntry entry = Dns.GetHostEntry("www.microsoft.com");
            foreach (IPAddress ipAddress in entry.AddressList)
            {
                Console.WriteLine(ipAddress);
            }


            string myComputer = Dns.GetHostName();
            Console.WriteLine("컴퓨터 이름: " + myComputer);

            IPHostEntry entry1 = Dns.GetHostEntry(myComputer);
            foreach (IPAddress ipADDress in entry.AddressList)
            {
                Console.WriteLine(ipADDress.AddressFamily + ": " + ipADDress);
            }
        }
    }
}
