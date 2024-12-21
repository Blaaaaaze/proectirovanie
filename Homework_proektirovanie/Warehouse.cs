using System;

public class Warehouse
{
    public int WarehouseId { get; set; }
    public string Location { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public void CheckStock()
    {
        Console.WriteLine("Проверка продуктов");
        foreach (var product in Products)
        {
            product.GetDetails();
        }
    }

    public void AddStock(Product product, int quantity)
    {
        // Компоновщик
        product.UpdateStock(quantity);
        if (!Products.Contains(product))
        {
            Products.Add(product);
        }
    }
}
