using AdapterPattern;
using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;
using AdapterPattern.Models;

IPaymentManager externalPaymentAdapter = new ExternalPaymentAdapter();
IPaymentManager paymentManager = new PaymentManager();

var currency = new EuroCurrency()
{
    Amount = 100.00,
    ConversionRate = 19.43
};

paymentManager.ProcessPayment(currency);
externalPaymentAdapter.ProcessPayment(currency);
