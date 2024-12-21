class Program
{
    static void Main(string[] args)
    {
        FahrenheitTemperatureSensor FTS = new FahrenheitTemperatureSensor(50);
        CelsiyTemperatureSensor CTS = new CelsiyTemperatureSensor(FTS.GetTemperature());
        ITemperatureSensor ITS = new TemperatureAdapter(CTS);
        Console.WriteLine("Теспература в Фаренгейтах - {0} градусов, в Цельсиях - {1} градусов", FTS.GetTemperature(), ITS.GetTemperature());
    }
}
// Кажется, что лучше он применяется для какой-то побочной функции. Возможно для ситуаций,
// где объекты отличаются коэффициента - например, курс валют