namespace MediatorPattern.Notifiers;

public class PushNotifier : INotifier
{
    public void Notify(string notification)
    {
        Console.WriteLine($"[PUSH] {notification}");
    }
}