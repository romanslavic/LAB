using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDP_conection
{
    public static class Send
    {
        public static void SendData(Socket socket, byte[] message, EndPoint endpoint)
        {
            try
            {
                socket.SendTo(message, endpoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message: {ex.Message}");
            }
        }

        public static void SendMessage(Socket privateSocket, IPAddress localAddress, int broadcastPort, Socket generalSocket)
        {
            while (true)
            {
                var message = Console.ReadLine();
                if(string.IsNullOrEmpty(message))
                {
                    continue;
                }

                if (message.StartsWith("port"))
                {
                    var parts = message .Split(' ', 3);
                    int targetPort = int.Parse(parts[1]);
                    string privateMessage = parts[2];
                    SendData(privateSocket, Encoding.UTF8.GetBytes(privateMessage), new IPEndPoint(localAddress, targetPort));
                }
                else
                {
                    SendData(generalSocket, Encoding.UTF8.GetBytes(message), new IPEndPoint(IPAddress.Broadcast, broadcastPort));
                }

            }
        }
    }
}
