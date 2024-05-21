using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_shopping_cart.Dtos;
using test_shopping_cart.Models;

namespace test_shopping_cart.Services
{
    public interface IProductService
    {
        Task<(bool error , string errorMessage , List<GetProductDto> product)>GetAll();
        Task<(bool error , string errorMessage , List<Product> product)>GetProductById(string id);
    }
}