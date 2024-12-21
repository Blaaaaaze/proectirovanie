using System;

class DrunkDriver : TransportService
{
    public int Degree { get; set; }

    public DrunkDriver(string name, int deg) :
        base(name)
    {
        Degree = deg;
    }

    public override double CostTransportation(double distance)
    {
        return distance * Degree;
    }

    public override string ToString()
    {
        string s = String.Format("Фирма {0}, со степенью {1}",
            Name, Degree);
        return s;
    }
}
