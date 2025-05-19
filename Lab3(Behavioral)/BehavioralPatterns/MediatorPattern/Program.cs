using MediatorPattern.Mediators;
using MediatorPattern.Notifiers;

var mediator = new NotificationMediator();

mediator.Register(new EmailNotifier());
mediator.Register(new SmsNotifier());
mediator.Register(new PushNotifier());

mediator.SendNotification("The prices have been updated!");