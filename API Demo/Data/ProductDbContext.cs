using System;
using System.Collections.Generic;
using System.Linq;
using API_Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace API_Demo.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            LoadDefaultProducts();
        }

        private void LoadDefaultProducts()
        {
            Products.Add(new Product()
            {
                Id = 1,
                Category = ProductCategory.Cement,
                Name = "Cement Pack 5kg",
                Description =
                    "A cement is a binder, a substance used for construction that sets, hardens, and adheres to other materials to bind them together",
                Image = "./cement.jpg",
                Price = 35.99,
                Stock = 100,
            });
        }

        public IEnumerable<Product> GetProducts() => Products.Local.ToList();

        public bool AddQuestion(int id, string question)
        {
            try
            {
                var productUnderQuestion = Products.Local.Single(c => c.Id == id);
                productUnderQuestion.Question.Append(new QandA()
                {
                    Id = 1,
                    Question = question,
                    Answer = null
                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}