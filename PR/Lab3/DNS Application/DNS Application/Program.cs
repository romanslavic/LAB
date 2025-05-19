using DNS_Application;

Console.WriteLine("DNS Lookup Tool");
Console.WriteLine("==================");

DnsLookup dnsLookup = new DnsLookup();

while (true)
{
    Console.Write("Enter Command: ");
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "exit")
    {
        break;
    }

    dnsLookup.ProcessInput(input);
}