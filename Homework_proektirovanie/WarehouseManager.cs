using System;

public class WarehouseManager : User
{
    // Использован шаблон контроллер
    public void CheckStock()
    {
        Console.WriteLine("Проверка количества на складе");
    }

    public void AddStock()
    {
        Console.WriteLine("Обновление количества товара");
    }
}