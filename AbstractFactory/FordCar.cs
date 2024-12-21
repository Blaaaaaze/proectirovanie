using System;

class FordCar : AbstractCar
{
    public FordCar(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public override int MaxSpeed(AbstractEngine engine)
    {
        int ms = engine.max_speed;
        return ms;
    }

    public override string ToString()
    {
        return "Автомобиль " + Name + " тип кузова " + Type;
    }
}
