using System;

class AudiFactory : CarFactory
{
    AudiFactory() { }

    static Lazy<AudiFactory> myAudi = new Lazy<AudiFactory>(()=> new AudiFactory());
    public static AudiFactory MyAudi
    {
        get { return myAudi.Value; }
    }

    public override AbstractCar CreateCar()
    {
        return new AudiCar("Ауди", "купе");
    }
    public override AbstractEngine CreateEngine()
    {
        return new AudiEngine();
    }
}