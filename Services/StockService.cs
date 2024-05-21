using Microsoft.EntityFrameworkCore;
using test_shopping_cart.Data;
using test_shopping_cart.Dtos;
using test_shopping_cart.Models;

namespace test_shopping_cart.Services;
public class StockService : IStockService
{
    private readonly AppDbContext _context;
    public StockService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<(bool error, string errorMessage, List<StockInven> StockInven)> GetStock()
    {
        (bool error, string errorMessage, List<StockInven> data) result = new();
        try
        {
            result.data = await _context.StockInven.Include(x => x.Product).ToListAsync();
            return result;
        }
        catch (Exception ex)
        {
            result.error = true;
            result.errorMessage = ex.Message;
            result.data = new List<StockInven>();
            return result;
        }
    }

    public async Task<(bool error, string errorMessage)> Submit(List<SubmitAddToCartDto> stocks)
    {
        (bool error, string errorMessage) result = new();
        try
        {
            if (stocks.Count() == 0) return result;

            var list = stocks.Select(x => x.ProductId).ToList();
            var itemUpdate = await _context.StockInven.Include(x => x.Product).Where(i => list.Contains(i.Product.ProductId.ToString()))
            .ToListAsync();

            foreach (var s in stocks)
            {
                var newStock = itemUpdate.Single(i => i.Product.ProductId.Equals(Guid.Parse(s.ProductId)));
                newStock.Amount = newStock.Amount - s.Qty;
                await _context.SaveChangesAsync();
            }

            return result;
        }
        catch (Exception ex)
        {
            result.error = true;
            result.errorMessage = ex.Message;
            return result;
        }
    }
}