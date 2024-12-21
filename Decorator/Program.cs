using System;

class Program
{
    static void Main(string[] args)
    {
        Renault reno = new Renault("Рено", "Renault Logan Active", 499.0);

        Print(reno);

        AutoBase myreno = new MediaNAV(reno, "Навигация");

        Print(myreno);

        AutoBase newmyreno = new SystemSecurity(new MediaNAV(reno, "Навигация"), "Безопасность");
        Print(newmyreno);

        Porche porche = new Porche("Порш", "Porche 911", 799.0);

        Print(porche);

        AutoBase newporche = new SportMode(porche, "Спортивный режим");

        Print(newporche);

        AutoBase mynewporche = new FoldingRoof(new SportMode(porche, "Спортивный режим"), "Откидная крыша");

        Print(mynewporche);
    }

    private static void Print(AutoBase av)
    {
        Console.WriteLine(av.ToString());
    }
}