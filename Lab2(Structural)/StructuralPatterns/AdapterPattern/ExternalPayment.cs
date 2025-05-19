namespace AdapterPattern;

public class ExternalPayment
{
    public void ProcessUsdPayment(double amount)
    {
        Console.WriteLine($"External payment process: {amount} USD");
    }
}