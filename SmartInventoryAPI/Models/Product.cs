namespace SmartInventoryAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; } = 0;
    }
}