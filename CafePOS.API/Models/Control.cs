using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Control
    {
        public Control()
        {
            RoleControl = new HashSet<RoleControl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public ICollection<RoleControl> RoleControl { get; set; }
    }
}
