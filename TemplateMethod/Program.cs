using System;

class Program
{
    static void Main(string[] args)
    {
        int f, l, h;

        Console.WriteLine("Введите первое целое число:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введите второе целое число:");
        string input2 = Console.ReadLine();

        Console.WriteLine("Введите третье целое число:");
        string input3 = Console.ReadLine();

        int.TryParse(input1, out f);
        int.TryParse(input2, out l);
        int.TryParse(input3, out h);

        Progression val = new ArithmeticProgression(f, l, h);
        val.TemplateMethod();

        Progression val1 = new GeometryProgression(f, l, h);
        val1.TemplateMethod();
    }
}