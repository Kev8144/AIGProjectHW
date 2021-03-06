using System;
using System.Collections.Generic;
using System.Text;

namespace AIGProject.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
    }
}
