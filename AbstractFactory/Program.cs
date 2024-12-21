class Program
{
    static void Main(string[] args)
    {
        CarFactory ford_car = new FordFactory();
        Client c1 = new Client(ford_car);

        Console.WriteLine("Максимальная скорость {0} составляет {1} км/час",
            c1.ToString(), c1.RunMaxSpeed());

        CarFactory audi_car = AudiFactory.MyAudi;
        Client c2 = new Client(audi_car);
        Console.WriteLine("Максимальная скорость {0} составляет {1} км/час",
            c2.ToString(), c2.RunMaxSpeed());
    }
}

// Довольно муторные однотипные действия.
// Важно ничего не упустить и не создать дубликатов.