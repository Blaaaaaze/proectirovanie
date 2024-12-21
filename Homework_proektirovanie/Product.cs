using System;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int StockQuantity { get; set; }

    public void UpdateStock(int quantity)
    {
        // щаблон Компоновщик
        StockQuantity += quantity;
        Console.WriteLine("Запасы обновлены. Новое количество: {0}.", StockQuantity);
    }

    public void GetDetails()
    {
        Console.WriteLine("Товар: {0}, Количество: {1}.", Name, StockQuantity);
    }
}
