using System;

class TemperatureAdapter : ITemperatureSensor
{
    CelsiyTemperatureSensor cel;

    public TemperatureAdapter(CelsiyTemperatureSensor cl)
    {
        cel = cl;
    }

    public double GetTemperature()
    {
        return cel.GetTemperatureC();
    }
}

