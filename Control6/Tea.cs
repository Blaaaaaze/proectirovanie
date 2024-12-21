using System;
class Tea : Beverage
{
    protected override void AddIngredients()
    {
        Console.WriteLine("Добавляем чайные листья.");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Добавляем лимон.");
    }
}