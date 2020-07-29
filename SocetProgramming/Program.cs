using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));
        Server.Listen(100);

        Socket Client = Server.Accept();
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[] { 65, 66, 67, 68 };
        Client.Send(Buffer);


        Client.Close();
        Server.Close();
    }



}