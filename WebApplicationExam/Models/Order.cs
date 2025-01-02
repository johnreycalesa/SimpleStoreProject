using System.Collections.Generic;
namespace WebApplicationExam.Models

{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }
        public List<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal NetCost { get; set; }
    }

    public class OrderSummary
    {
        public int OrderId { get; set; }
        public decimal NetPrice { get; set; }
    }

}
