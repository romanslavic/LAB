namespace MediatorPattern.Notifiers;

public class SmsNotifier : INotifier
{
    public void Notify(string notification)
    {
        Console.WriteLine($"[SMS] {notification}");
    }
}