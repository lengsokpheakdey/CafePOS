using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class RoleControl
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? ControlId { get; set; }

        public Control Control { get; set; }
        public Role Role { get; set; }
    }
}
