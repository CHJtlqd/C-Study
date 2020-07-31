using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpListener aTcpListener = new TcpListener(IPAddress.Any, 7000);     //socket listen 포함
            aTcpListener.Start();
            Console.WriteLine("Starting Server........");

            TcpClient aTcpClient = aTcpListener.AcceptTcpClient();
            Console.WriteLine("Client Enter........");
            aTcpListener.Stop();

            NetworkStream aNetworkStream = aTcpClient.GetStream();
            byte[] buffer = new byte[1024];
            int BufferCount = aNetworkStream.Read(buffer, 0, buffer.Length);
            Console.WriteLine("클라이언트가 전송한 데이터 크기(byte) : " + BufferCount);
            Console.WriteLine("클라이언트가 전송한 내용" + Encoding.UTF8.GetString(buffer));

            buffer = Encoding.UTF8.GetBytes("집가고싶다.");
            aNetworkStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine("클라이언트로 회신한 Data 내용 : " + Encoding.UTF8.GetString(buffer));

            Console.WriteLine("서버를 종료합니다...");
            aNetworkStream.Close();
            aTcpClient.Close();
        }
    }
}
