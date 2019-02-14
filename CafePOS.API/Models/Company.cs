using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameKh { get; set; }
        public string ImgUrl { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
