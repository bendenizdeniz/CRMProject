using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.Models
{
    public class CustomerUserModel
    {
        public Customer Customer { get; set; }

        public User User { get; set; }

        public List<Customer> CustomerList { get; set; }

        public List<User> UserList { get; set; }

        public User AccountUser { get; set; }
    }
}
