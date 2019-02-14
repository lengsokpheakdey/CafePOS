using System;
using System.Collections.Generic;

namespace CafePOS.API.Models
{
    public partial class User
    {
        public User()
        {
            MenuCreateByNavigation = new HashSet<Menu>();
            MenuUpdateByNavigation = new HashSet<Menu>();
            Payment = new HashSet<Payment>();
            Sale = new HashSet<Sale>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
        public int? StatusId { get; set; }

        public Status Status { get; set; }
        public ICollection<Menu> MenuCreateByNavigation { get; set; }
        public ICollection<Menu> MenuUpdateByNavigation { get; set; }
        public ICollection<Payment> Payment { get; set; }
        public ICollection<Sale> Sale { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
