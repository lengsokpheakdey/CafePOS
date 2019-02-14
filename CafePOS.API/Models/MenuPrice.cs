using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class MenuPrice
    {
        public int Id { get; set; }
        public int? MenuId { get; set; }
        public int? SizeId { get; set; }
        public decimal? Price { get; set; }

        public Menu Menu { get; set; }
        public Size Size { get; set; }
    }
}
