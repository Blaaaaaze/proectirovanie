class Program
{
    static void Main(string[] args)
    {
        
        SalesRepresentative rep = new SalesRepresentative { Id = 1, Name = "Александр" };
        rep.Login();

        
        Product product = new Product { ProductId = 101, Name = "Ноутбук", StockQuantity = 10 };
        Warehouse warehouse = new Warehouse { WarehouseId = 1, Location = "Главный склад" };

        warehouse.AddStock(product, 5);
        warehouse.CheckStock();

        
        Order order = new Order { OrderId = 5001, Status = "Рассмотрение" };
        rep.CreateOrder();
        order.CreateOrder();

        rep.Logout();
    }
}