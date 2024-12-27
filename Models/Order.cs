namespace ShopEase.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public double CalculateNetPrice(IEnumerable<Product> products)
        {
            return Items.Sum(item =>
            {
                var product = products.FirstOrDefault(p => p.Id == item.Id);
                return product != null ? product.Price * item.Quantity : 0;
            });
        }
    }
}