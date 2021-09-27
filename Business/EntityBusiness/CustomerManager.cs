using Business.Interfaces;
using DAL.Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.EntityBusiness
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerManager(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }

        public Customer CreateCustomer(Customer customer)
        {
            return customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            customerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetAllCustomer()
        {
            return customerRepository.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return customerRepository.UpdateCustomer(customer);
        }


    }
}
