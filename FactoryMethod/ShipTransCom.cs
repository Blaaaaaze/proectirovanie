using System;

class ShipTransCom : TransportCompany
{
    public ShipTransCom(string name) : base(name) { }

    public override TransportService Create(string n, int t)
    {
        return new Shipping(n, t);
    }
}
