using System;

class SportMode : DecoratorOptions
{
    public SportMode(AutoBase p, string t) : base(p, t)
    {
        AutoProperty = p;

        Name = p.Name + ". Большие скорости";

        Description = p.Description + " " + this.Title + ". Спортивный режим";

    }

    public override double GetCost()
    {
        return AutoProperty.GetCost() + 199.99;
    }
}