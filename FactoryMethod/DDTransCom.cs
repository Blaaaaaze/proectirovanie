using System;

class DDTransCom : TransportCompany
{
    public DDTransCom(string name) : base(name)
    { }

    public override TransportService Create(string n, int d)
    {
        return new DrunkDriver(n, d);
    }
}
