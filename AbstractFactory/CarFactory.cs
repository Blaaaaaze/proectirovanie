using System;

abstract class CarFactory
{
    public abstract AbstractCar CreateCar();
    public abstract AbstractEngine CreateEngine();
}
