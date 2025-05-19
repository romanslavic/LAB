using System.Net;
using System.Net.Sockets;

namespace WebNTP.Clients;

public class NtpClient
{
    private const string NtpServer = "pool.ntp.org";
    private const int NtpPort = 123;

    public static DateTime GetNetworkTime()
    {
        var ntpData = new byte[48];
        ntpData[0] = 0x23;

        var addresses = Dns.GetHostEntry(NtpServer).AddressList;
        var ipEndPoint = new IPEndPoint(addresses[0], NtpPort);

        using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        socket.Connect(ipEndPoint);
        socket.Send(ntpData);
        socket.ReceiveTimeout = 3000;
        socket.Receive(ntpData);

        ulong intPart = BitConverter.ToUInt32(ntpData[40..44].Reverse().ToArray(), 0);
        ulong fracPart = BitConverter.ToUInt32(ntpData[44..48].Reverse().ToArray(), 0);
        var milliseconds = (intPart * 1000) + ((fracPart * 1000) / 0x100000000L);
        
        var networkDateTime = new DateTime(1900, 1, 1).AddMilliseconds((long)milliseconds);
        return networkDateTime.ToLocalTime();
    }
}