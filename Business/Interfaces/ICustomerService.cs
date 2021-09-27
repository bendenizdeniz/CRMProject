using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer customer);

        List<Customer> GetAllCustomer();

        Customer GetCustomerById(int id);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);

    }
}
