using System.Text.Json.Serialization;

namespace test_shopping_cart.Models
{
    public class StockInven
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsAction {get;set;}  
        public Guid ProductId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
    }
}