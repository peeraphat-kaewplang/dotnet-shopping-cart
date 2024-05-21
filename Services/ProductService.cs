using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test_shopping_cart.Data;
using test_shopping_cart.Dtos;
using test_shopping_cart.Models;

namespace test_shopping_cart.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<(bool error, string errorMessage, List<GetProductDto> product)> GetAll()
        {
            (bool error, string errorMessage , List<GetProductDto> data) result = new();
            try
            {
                result.data = await _context.Product.Include(x => x.StockInven).Select(p => GetProductDto.ConvertModelToGetProductDtoExtensions(p)).ToListAsync();
                return  result;
            }
            catch (Exception ex)
            {
                result.error = true;
                result.errorMessage = ex.Message;
                result.data = new List<GetProductDto>();
                return result;
            }
        }   

        public Task<(bool error, string errorMessage, List<Product> product)> GetProductById(string id)
        {
            throw new NotImplementedException();
        }
    }
}