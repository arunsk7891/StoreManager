using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocalCart : ControllerBase
    {
        
        private readonly ILogger<LocalCart> _logger;

        public LocalCart(ILogger<LocalCart> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get(string userId, string productId, int quantity)
        {
            var rng = new Random();

            Console.WriteLine($"AddItemAsync called with userId={userId}, productId={productId}, quantity={quantity}");
            var sum = "AddItem  called with userId= " + userId + "  Product " + productId;

            return sum;
        }
    }
}
