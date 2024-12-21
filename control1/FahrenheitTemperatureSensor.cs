using System;

class FahrenheitTemperatureSensor : ITemperatureSensor
{
    double gradus;

    public FahrenheitTemperatureSensor(double grad)
    {
        gradus = grad;
    }

    public double GetTemperature()
    {
        
        return gradus; 
    }
}
