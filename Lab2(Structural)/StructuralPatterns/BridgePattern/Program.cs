using BridgePattern.Abstractions;
using BridgePattern.ConcreteManagers;
using BridgePattern.Implementors;
using BridgePattern.Interfaces;

IPaymentProcessor paypalProcessor = new PaypalPaymentProcessor();
IPaymentProcessor creditCardProcessor = new CreditCardPaymentProcessor();
IPaymentProcessor cryptoProcessor = new CryptoPaymentProcessor();

PaymentManager paymentManager = new SubscriptionPaymentManager(paypalProcessor);
paymentManager.ProcessPayment(100);
paymentManager = new OneTimePaymentManager(creditCardProcessor);
paymentManager.ProcessPayment(100);
paymentManager = new SubscriptionPaymentManager(cryptoProcessor);
paymentManager.ProcessPayment(100);