using System.Net;
using System.Net.NetworkInformation;
using DnsClient;

namespace DNS_Application;

public class DnsLookup
{
    private string _dnsServer = "8.8.8.8";
    private LookupClient _lookupClient;

    public DnsLookup()
    {
        _lookupClient = new LookupClient(IPAddress.Parse("8.8.8.8"), 53);
    }

    public void SetDnsServer(string dnsServer)
    {
        _lookupClient = new LookupClient(new IPEndPoint(IPAddress.Parse(_dnsServer), 53));
        var results = _lookupClient.Query(dnsServer.ToLower(), QueryType.A);
        if (results.Answers.Count > 0)
        {
            Console.WriteLine($"{dnsServer} is not a valid DNS server");
            return;
        }
        _dnsServer = dnsServer;
        Console.WriteLine($"DNS server changed to: {_dnsServer}");
    }

    public void ProcessInput(string input)
    {
        try
        {
            if (input.StartsWith("use dns", StringComparison.OrdinalIgnoreCase))
            {
                var parts = input.Split(' ');
                if (parts.Length == 3 && Helpers.IsIpAddress(parts[2]))
                {
                    SetDnsServer(parts[2]);
                }
                else
                {
                    Console.WriteLine("Invalid DNS server IP address.");
                }
                return;
            }

            if (input.StartsWith("resolve", StringComparison.OrdinalIgnoreCase))
            {
                var parts = input.Split(' ');
                if (parts.Length == 2)
                {
                    string domainOrIp = parts[1];
                    PerformDnsLookup(domainOrIp);
                }
                else
                {
                    Console.WriteLine("Invalid command format.");
                }
                return;
            }
            
            Console.WriteLine("Invalid command.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private void PerformDnsLookup(string input)
    {
        try
        {
            if (Helpers.IsIpAddress(input))
            {
                var results = _lookupClient.QueryReverse(IPAddress.Parse(input));
                foreach (var ptrRecord in results.Answers.PtrRecords())
                {
                    Console.WriteLine($"Domain name: {ptrRecord.PtrDomainName}");
                }
            }
            else
            {
                var results = _lookupClient.Query(input.ToLower(), QueryType.A);
                foreach (var aRecord in results.Answers.ARecords())
                {
                    Console.WriteLine($"IP Address: {aRecord.Address}");
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
