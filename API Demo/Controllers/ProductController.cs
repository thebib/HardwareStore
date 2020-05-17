using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using API_Demo.Data;
using API_Demo.Model;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace API_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        [HttpGet]
        public IEnumerable<Product> GetAllProducts([FromQuery] double? min, [FromQuery] double? max)
        {
            var minimumPrice = min ?? 0;
            var maximumPrice = max ?? double.MaxValue; 
            
            IEnumerable<Product> products = HardwareStoreData.GetProducts()
                .Where(c => c.Price > minimumPrice && c.Price < maximumPrice);
            return products;
        }

        [HttpGet("{Category}")]
        public IEnumerable<Product> GetProductByCategory([FromQuery] double? min, [FromQuery] double? max, string category)
        {
            var minimumPrice = min ?? 0;
            var maximumPrice = max ?? double.MaxValue; 

            IEnumerable<Product> products = HardwareStoreData.GetProducts()
                .Where(c => c.Category.ToString() == category)
                .Where(c => c.Price > minimumPrice && c.Price < maximumPrice);
           
            return products;
        }
    }
}