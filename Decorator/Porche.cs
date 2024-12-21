using System;

class Porche : AutoBase
{
    public Porche(string name, string info, double costbase)
    {
        Name = name;
        Description = info;
        CostBase = costbase;
    }

    public override double GetCost()
    {
        return CostBase * 1.18;
    }
}