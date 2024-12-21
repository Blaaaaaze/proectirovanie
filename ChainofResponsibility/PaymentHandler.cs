using System;

abstract class PaymentHandler
{
    public PaymentHandler Succesor { get; set; }

    public abstract void Handle(Receiver receiver);
}
