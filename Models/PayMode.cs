namespace SupermarketWEB.Models
{
    public class PayMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Pay_Mode { get; set; }
        public ICollection<Product>? Products { get; set; } = default!;
    }
}
