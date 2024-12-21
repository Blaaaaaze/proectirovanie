using System;

class Coffee : Beverage
{
    protected override void AddIngredients()
    {
        Console.WriteLine("Добавляем молотый кофе.");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Добавляем сахар и молоко.");
    }
}