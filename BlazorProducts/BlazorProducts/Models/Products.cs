using System;
using System.Collections.Generic;

namespace BlazorProducts.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
