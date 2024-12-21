using System;

class CelsiyTemperatureSensor
{
    double gradus;

    public CelsiyTemperatureSensor(double grad)
    {
        gradus = grad;
    }
    public double GetTemperatureC()
    {
        return (gradus - 32) * 5.0 / 9.0;
    }
}