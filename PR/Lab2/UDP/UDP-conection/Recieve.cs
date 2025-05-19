using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDP_conection
{
    public class Recieve
    {
        public void  RecieveDataAsync(Socket socket)
        {
            byte[] buffer = new byte[1024];
            EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);

            try
            {
                    int length = socket.ReceiveFrom(buffer, ref senderEndPoint);
                    string message = Encoding.UTF8.GetString(buffer, 0, length);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[Broadcast] {senderEndPoint}: {message}");
                    Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving message: {ex.Message}");
            }
        }

        public void RecievePrivate(Socket privateSocket, int port)
        {
            byte[] data = new byte[1024];
            EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, port);

            try
            {
                var result =  privateSocket.Receive(data);

                var message = Encoding.UTF8.GetString(data, 0, result);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"[Private] {senderEndPoint}: {message}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving private message: {ex.Message}");
            }
        }

        public void StartRecieveGeneral(Socket generalSocket)
        {
            Task.Run(() =>
            {
                var receiver = new Recieve();
                while (true)
                {
                    receiver.RecieveDataAsync(generalSocket);
                }
            });
        }

        public void StartReceivePrivate(Socket privateSocket, int port)
        {
            Task.Run(() =>
            {
                var receiver = new Recieve();
                while (true)
                {
                    receiver.RecievePrivate(privateSocket, port);
                }
            });
        }

    }
}
