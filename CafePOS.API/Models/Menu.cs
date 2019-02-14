using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Menu
    {
        public Menu()
        {
            MenuPrice = new HashSet<MenuPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? SubId { get; set; }
        public int? StatusId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public User CreateByNavigation { get; set; }
        public Status Status { get; set; }
        public SubCategory Sub { get; set; }
        public User UpdateByNavigation { get; set; }
        public ICollection<MenuPrice> MenuPrice { get; set; }
    }
}
