using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class SaleDetail
    {
        public Guid Id { get; set; }
        public Guid? SaleId { get; set; }
        public int? MenuId { get; set; }
        public string ProductName { get; set; }
        public string ProductSize { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Total { get; set; }

        public Sale Sale { get; set; }
    }
}
