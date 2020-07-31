using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient aTcpClient = new TcpClient("192.168.0.120",7000);
            Console.WriteLine("서버에 접속합니다........");

            NetworkStream aNetworkStream = aTcpClient.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes("클라이언트 : 집가고싶다.");

            aNetworkStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine("서버로 전송한 Data 내용 : " + Encoding.UTF8.GetString(buffer));

            buffer = new byte[1024];
            int BufferCount = aNetworkStream.Read(buffer, 0, buffer.Length);
            Console.WriteLine("서버가 전송한 데이터 크기(byte) : " + BufferCount);
            Console.WriteLine("서버가 전송한 내용" + Encoding.UTF8.GetString(buffer));


            Console.WriteLine("서버와 연결을 종료합니다...");
            aNetworkStream.Close();
            aTcpClient.Close();
        }
    }
}
