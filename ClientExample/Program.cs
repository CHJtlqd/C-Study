using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        Server.Connect(new IPEndPoint(IPAddress.Parse("192.168.0.120"), 7000));   // 특정 IP:포트에 연결설정

        // byte[] Buffer = new byte[] { 65, 66, 67, 68 }; // Telnet은 2byte로 해석 못함 1byte ASCII코드로 해석
        byte[] Buffer = Encoding.UTF8.GetBytes("보낸다 Client");
        Server.Send(Buffer);

        int Number = Server.Receive(Buffer);     // return 값으로 받은 바이트 수
        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Number));

        Server.Close();
    }
}