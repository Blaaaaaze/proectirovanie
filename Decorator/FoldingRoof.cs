using System;

class FoldingRoof : DecoratorOptions
{
    public FoldingRoof(AutoBase p, string t) : base(p, t)
    {
        AutoProperty = p;

        Name = p.Name + ". Роскошь и элегантность";

        Description = p.Description + " " + this.Title + ". Откидная крыша для езды летом";

    }

    public override double GetCost()
    {
        return AutoProperty.GetCost() + 315.99;
    }
}