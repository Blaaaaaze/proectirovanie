using System;

class Program
{
    static void Main(string[] args)
    {
        Receiver receiver = new Receiver(true, true, false);

        PaymentHandler bankPaymentHandler = new BankPaymentHandler();
        PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
        PaymentHandler paypalPaymenthandler = new PayPalPaymentHandler();

        paypalPaymenthandler.Succesor = bankPaymentHandler;
        bankPaymentHandler.Succesor = moneyPaymentHandler;

        bankPaymentHandler.Handle(receiver);
    }
}