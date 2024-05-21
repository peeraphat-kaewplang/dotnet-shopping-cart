using test_shopping_cart.Models;

namespace test_shopping_cart.Dtos
{
    public class GetProductDto
    {
        public Guid ProductId { get; set; }
        public string SkuCode { get; set; } = string.Empty;
        public string SkuName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public double UnitPrice { get; set; }

        public static GetProductDto ConvertModelToGetProductDtoExtensions(Product model)
        {
            return new GetProductDto
            {
                ProductId = model.ProductId,
                SkuCode = model.SkuCode,
                SkuName = model.SkuName,
                Amount = model.StockInven!.Amount,
                UnitPrice = model.StockInven!.UnitPrice,
            };
        }
    }


}