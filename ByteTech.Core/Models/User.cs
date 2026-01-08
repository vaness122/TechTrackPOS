using ByteTech.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
        public string Address { get; set; }
        public string Tin { get; set; }

        public decimal CreditLimit { get; set; }
        public decimal CreditUsed { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? LastLogin { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        //empty cons
        public User() { }
        //cons with argument
        public User(string firstName , string lastName , string email , string userName)
        {
            FirstName = firstName;  
            LastName = lastName;
            Email = email;
            UserName = userName;
        }



    }
}
