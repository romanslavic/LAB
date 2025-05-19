using MediatorPattern.Notifiers;

namespace MediatorPattern.Mediators;

public class NotificationMediator : INotificationMediator
{
    private readonly List<INotifier> _notifiers = [];

    public void Register(INotifier notifier)
    {
        _notifiers.Add(notifier);
    }

    public void SendNotification(string notification)
    {
        foreach (var notifier in _notifiers)
        {
            notifier.Notify(notification);
        }
    }
}