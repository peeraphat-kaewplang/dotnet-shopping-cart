using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_shopping_cart.Dtos
{
    public class SubmitAddToCartDto
    {
        public string ProductId { get; set; }
        public int Qty { get; set; }
    }
}