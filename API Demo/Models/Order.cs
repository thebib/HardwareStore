using System;
using API_Demo.Model;

namespace API_Demo.Models
{
    public class Order
    {
        public DateTime OrderPlacedDate { get; set; }
        public Product ProductOrdered { get; set; }
        public int Quantity { get; set; }
        public ShippingOption ShippingOption
        {
            get;
            set;
        }
    }

    public enum ShippingOption
    {
        NextDay,
        Express,
        Standard
    }
}