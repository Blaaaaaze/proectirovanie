using System;

class FordFactory : CarFactory
{
    public override AbstractCar CreateCar()
    {
        return new FordCar("Форд", "седан");
    }
    public override AbstractEngine CreateEngine()
    {
        return new FordEngine();
    }
}
