using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Size
    {
        public Size()
        {
            MenuPrice = new HashSet<MenuPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public ICollection<MenuPrice> MenuPrice { get; set; }
    }
}
