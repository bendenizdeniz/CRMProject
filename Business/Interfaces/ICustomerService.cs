using Entity;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Customer CreateCustomer(Customer customer);

        List<Customer> GetAllCustomer();

        Customer GetCustomerById(int id);

        Customer GetCustomerByName(string name);

        Customer UpdateCustomer(Customer customer);

        void DeleteCustomer(int id);

    }
}
