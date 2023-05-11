namespace SupermarketWEB.Models
{
    public class ShopSell
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public float Price_Xuni { get; set; }
        public float Amount { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; } = default!;
    }
}
