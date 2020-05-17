using System;
using System.Collections.Generic;
using System.Linq;
using API_Demo.Model;
using API_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Demo.Data
{
    public static class HardwareStoreData
    {
        public static volatile List<Product> Products;
        public static volatile List<Question> Questions;

        static HardwareStoreData()
        {
            InitializeObjects();
            LoadDefaultProducts();
            LoadDefaultQuestions();
        }

        private static void InitializeObjects()
        {
            Products = new List<Product>();
            Questions = new List<Question>();
        }

        private static void LoadDefaultQuestions()
        {
            Questions.Add(new Question()
            {
                Value = "What is 2+2?",
                Answer = "4"
            });
        }
        
        private static void LoadDefaultProducts()
        {
            Products.Add(new Product()
                {
                    Category = ProductCategory.Cement,
                    Name = "Cement Pack 5kg",
                    Description =
                        "A cement is a binder, a substance used for construction that sets, hardens, and adheres to other materials to bind them together",
                    Image = "./cement.jpg",
                    Price = 35.99,
                    Stock = 100,
                    ShippingOptions = new List<ShippingOption>()
                    {
                        ShippingOption.Express,
                        ShippingOption.Standard
                    }
                }
            );
            Products.Add(new Product()
                {
                    Category = ProductCategory.Batteries,
                    Name = "AA Battery",
                    Description =
                        "A battery is a device consisting of one or more electrochemical cells with external connections",
                    Image = "./battery.jpg",
                    Price = 4.99,
                    Stock = 4500,
                    ShippingOptions = new List<ShippingOption>()
                    {
                        ShippingOption.NextDay,
                        ShippingOption.Express,
                        ShippingOption.Standard
                    }
                }
            );
        }
        public static IEnumerable<Product> GetProducts() => Products.ToList();
    }
}