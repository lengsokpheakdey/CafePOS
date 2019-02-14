using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class MainCategory
    {
        public MainCategory()
        {
            SubCategory = new HashSet<SubCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? StatusId { get; set; }

        public Status Status { get; set; }
        public ICollection<SubCategory> SubCategory { get; set; }
    }
}
