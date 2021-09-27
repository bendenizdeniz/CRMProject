using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.Models
{
    public class CustomerUserListModel
    {
        public Customer customer { get; set; }
        public List<User> userList { get; set; }
        public string customersUserName { get; set; }
        public int customersUserId { get; set; }
    }
}
