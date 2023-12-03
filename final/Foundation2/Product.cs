public class Product
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public decimal CalculatePrice()
    {
        return Price * Quantity;
    }
}
