using System;

class SystemSecurity : DecoratorOptions
{
    public SystemSecurity(AutoBase p, string t) : base(p,t)
    {
        AutoProperty = p;

        Name = p.Name + ". Повышение безопасности";
        Description = p.Description + ". " + this.Title + ". Передние боковые подушки безопасности, ESP - система динамической стабилизации автомобиля";
    }

    public override double GetCost()
    {
        return AutoProperty.GetCost() + 20.99;
    }
}