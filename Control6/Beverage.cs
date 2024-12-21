using System;

abstract class Beverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        AddIngredients();
        Brew();
        PourInCup();
        AddCondiments();
    }
    private void BoilWater()
    {
        Console.WriteLine("Кипятим воду.");
    }

    protected abstract void AddIngredients(); 

    private void Brew()
    {
        Console.WriteLine("Завариваем напиток.");
    }

    private void PourInCup()
    {
        Console.WriteLine("Наливаем в чашку.");
    }

    protected abstract void AddCondiments(); 
}