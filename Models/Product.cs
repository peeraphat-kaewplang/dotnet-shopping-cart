using System.Text.Json.Serialization;

namespace test_shopping_cart.Models
{
  public class Product
    {
        public Guid ProductId { get; set; }
        public string SkuCode { get; set; } = string.Empty;
        public string SkuName { get; set; } = string.Empty;
        public double CostPrice { get; set; }
        public StockInven? StockInven { get; set; }
    }
}