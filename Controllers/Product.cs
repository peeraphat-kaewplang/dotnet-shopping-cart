using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test_shopping_cart.Services;

namespace test_shopping_cart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Product : ControllerBase
    {
        private readonly IProductService _iProductService;
        public Product(IProductService iProductService)
        {
            _iProductService = iProductService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var (error, errorMessage, product) = await _iProductService.GetAll();
            if(error) BadRequest(errorMessage);
            return Ok( product);
        }
    }
}