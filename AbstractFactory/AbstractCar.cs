using System;

abstract class AbstractCar
{
    public string Name { get; set; }
    public abstract int MaxSpeed(AbstractEngine engine);

    public string Type { get; set; }
}
