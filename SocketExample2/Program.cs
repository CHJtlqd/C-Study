using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));   // IPAddress.Any가 자동으로 내 IP를 찾아줌
        //   Server.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.120"), 7000));
        Console.WriteLine(IPAddress.Any.ToString());
        Server.Listen(100);     // 접속을 보관할 수 있는 큐의 길이를 Listen(number)로 나타냄.

        Socket Client = Server.Accept(); // 블로킹 함수 | 넌블로킹 
        Console.WriteLine("Client Incomming");

        // byte[] Buffer = new byte[] { 65, 66, 67, 68 }; // Telnet은 2byte로 해석 못함 1byte ASCII코드로 해석
        byte[] Buffer = new byte[1024];

        int Number = Client.Receive(Buffer);     // return 값으로 받은 바이트 수
        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Number));
        Buffer = Encoding.UTF8.GetBytes("보낸다 Server");
        Client.Send(Buffer);

        Client.Close();
        Server.Close();
    }
}