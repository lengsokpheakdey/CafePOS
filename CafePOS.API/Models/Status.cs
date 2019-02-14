using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Status
    {
        public Status()
        {
            MainCategory = new HashSet<MainCategory>();
            Menu = new HashSet<Menu>();
            SubCategory = new HashSet<SubCategory>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public ICollection<MainCategory> MainCategory { get; set; }
        public ICollection<Menu> Menu { get; set; }
        public ICollection<SubCategory> SubCategory { get; set; }
        public ICollection<User> User { get; set; }
    }
}
