using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));   // IPAddress.Any가 자동으로 내 IP를 찾아줌
        //   Server.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.120"), 7000));
        Console.WriteLine(IPAddress.Any.ToString());
        Server.Listen(100);

        Socket Client = Server.Accept(); // 블로킹 함수 | 넌블로킹 
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[] { 65, 66, 67, 68 }; // Telnet은 2byte로 해석 못함 1byte ASCII코드로 해석
        Client.Send(Buffer);


        Client.Close();
        Server.Close();
    }
}