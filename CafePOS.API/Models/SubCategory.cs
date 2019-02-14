using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Menu = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MainCategoryId { get; set; }
        public int? StatusId { get; set; }

        public MainCategory MainCategory { get; set; }
        public Status Status { get; set; }
        public ICollection<Menu> Menu { get; set; }
    }
}
