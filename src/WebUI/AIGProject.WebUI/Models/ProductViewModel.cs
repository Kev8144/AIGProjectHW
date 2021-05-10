using System;

namespace AIGProject.WebUI.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
    }
}
