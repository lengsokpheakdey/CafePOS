using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleControl = new HashSet<RoleControl>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }

        public ICollection<RoleControl> RoleControl { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
