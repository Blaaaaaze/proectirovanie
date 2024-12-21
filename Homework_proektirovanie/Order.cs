using System;

public class Order
{
    public int OrderId { get; set; }
    public string Status { get; set; }

    public void CreateOrder()
    {
        Console.WriteLine("Заказ создан");
    }

    public void CancelOrder()
    {
        Console.WriteLine("Заказ отменён");
    }
}
