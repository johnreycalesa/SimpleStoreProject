using Newtonsoft.Json;
namespace WebApplicationExam.Models
{
    public class Product
    {
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("cost")]
        public decimal Cost { get; set; }
    }


}
