using test_shopping_cart.Dtos;
using test_shopping_cart.Models;

namespace test_shopping_cart.Services
{
    public interface IStockService
    {
        Task<(bool error , string errorMessage , List<StockInven> StockInven)> GetStock();
        Task<(bool error , string errorMessage )> Submit(List<SubmitAddToCartDto> stocks);
    }
}