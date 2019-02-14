using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Payment
    {
        public Guid Id { get; set; }
        public Guid? SaleId { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TaxAmount { get; set; }
        public int? UserId { get; set; }
        public DateTime? PaidDate { get; set; }

        public Sale Sale { get; set; }
        public User User { get; set; }
    }
}
