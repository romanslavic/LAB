using System.Net;
using System.Net.Sockets;
using System.Text;

Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
serverSocket.Bind(new IPEndPoint(ipAddress, 3001));

serverSocket.Listen(5);

Console.WriteLine("Waiting for a connection...");
Socket connection = serverSocket.Accept();

Console.WriteLine("Connection accepted");
Console.WriteLine(connection.RemoteEndPoint.ToString());
Console.WriteLine();

while (true)
{
    string text = "";

    do
    {
        byte[] buffer = new byte[1024];
        int bytesRecieved = connection.Receive(buffer);
        
        text += Encoding.UTF8.GetString(buffer, 0, bytesRecieved);
    }while (connection.Available > 0);

    Console.WriteLine($"Received: {text}");
    
    byte[] bytesData = Encoding.UTF8.GetBytes("Server recieved message");
    
    connection.Send(bytesData);
}

serverSocket.Shutdown(SocketShutdown.Both);
serverSocket.Close();
Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
serverSocket.Bind(new IPEndPoint(ipAddress, 3001));

serverSocket.Listen(5);

Console.WriteLine("Waiting for a connection...");
Socket connection = serverSocket.Accept();

Console.WriteLine("Connection accepted");
Console.WriteLine(connection.RemoteEndPoint.ToString());
Console.WriteLine();

while (true)
{
    string text = "";

    do
    {
        byte[] buffer = new byte[1024];
        int bytesRecieved = connection.Receive(buffer);
        
        text += Encoding.UTF8.GetString(buffer, 0, bytesRecieved);
    }while (connection.Available > 0);

    Console.WriteLine($"Received: {text}");
    
    byte[] bytesData = Encoding.UTF8.GetBytes("Server recieved message");
    
    connection.Send(bytesData);
}

serverSocket.Shutdown(SocketShutdown.Both);
serverSocket.Close();