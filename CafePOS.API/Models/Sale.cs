using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Sale
    {
        public Sale()
        {
            Payment = new HashSet<Payment>();
            SaleDetail = new HashSet<SaleDetail>();
        }

        public Guid Id { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? UserId { get; set; }
        public int? QueueNo { get; set; }

        public User User { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<SaleDetail> SaleDetail { get; set; }
    }
}
