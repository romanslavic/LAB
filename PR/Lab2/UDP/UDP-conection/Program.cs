using System.Net;
using System.Net.Sockets;
using System.Text;
using UDP_conection;

class Program
{
    private static readonly IPAddress localAddress = IPAddress.Parse("127.0.0.1");

    static void Main()
    {
        var generalSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        generalSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        generalSocket.EnableBroadcast = true;
        generalSocket.Bind(new IPEndPoint(IPAddress.Any, 8800));

        Console.WriteLine("Enter the port number for the private connection: ");
        int privatePort = int.Parse(Console.ReadLine());

        var privateSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        privateSocket.EnableBroadcast = true;
        privateSocket.Bind(new IPEndPoint(localAddress, privatePort));


        Recieve recieve = new Recieve();

        recieve.StartRecieveGeneral(generalSocket);
        recieve.StartReceivePrivate(privateSocket, privatePort);

        Send.SendMessage(privateSocket, localAddress, 8800, generalSocket);

        Console.ReadLine();
    }
}
