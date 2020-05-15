using System;
using System.ComponentModel.DataAnnotations;

namespace API_Demo.Models
{
    public class Promotion
    {
        [Key] 
        public int Id { get; set; }
        
        public string Name { get; set; }
        public double? PercentageDiscount { get; set; }
        public double? PriceReduction { get; set; }
        public bool BoGoF { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
    }
}