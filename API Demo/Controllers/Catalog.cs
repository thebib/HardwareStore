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
    public class Catalog : Controller
    {
        public ProductDbContext _context;
        
        public Catalog(ProductDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts([FromQuery] double? min, [FromQuery] double? max)
        {
            var minimumPrice = min ?? 0;
            var maximumPrice = max ?? double.MaxValue; 
            
            IEnumerable<Product> products = _context.GetProducts()
                .Where(c => c.Price > minimumPrice && c.Price < maximumPrice);
            return products;
        }

        [HttpGet("{category}")]
        public IEnumerable<Product> GetProductByCategory([FromQuery] double? min, [FromQuery] double? max, string category)
        {
            var minimumPrice = min ?? 0;
            var maximumPrice = max ?? double.MaxValue; 

            IEnumerable<Product> products = _context.GetProducts()
                .Where(c => c.Category.ToString() == category)
                .Where(c => c.Price > minimumPrice && c.Price < maximumPrice);
           
            return products;
        }
    }
}