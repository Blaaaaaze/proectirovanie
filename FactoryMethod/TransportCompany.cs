using System;

abstract class TransportCompany
{
    public string Name { get; set; }

    public TransportCompany(string n)
    {
        Name = n;
    }

    public override string ToString()
    {
        return Name;
    }

    abstract public TransportService Create(string n, int k);
}
