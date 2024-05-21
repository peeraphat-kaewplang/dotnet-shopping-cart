using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test_shopping_cart.Dtos;
using test_shopping_cart.Models;
using test_shopping_cart.Services;

namespace test_shopping_cart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Stock : ControllerBase
    {
         private readonly IStockService _stockService;
        public Stock(IStockService stockService)
        {
            _stockService = stockService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var (error, errorMessage, stock) = await _stockService.GetStock();
            if(error) BadRequest(errorMessage);
            return Ok( new { data = stock});
        }
        [HttpPost]
        public async Task <IActionResult> SubmitCart(List<SubmitAddToCartDto> stocks)
        {
            var (error, errorMessage) = await _stockService.Submit(stocks);
            if(error) return BadRequest(errorMessage);
            return Ok();
        }
    }
}