using DAL.Interfaces;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityBusiness
{
    public class CustomerRepository : ICustomerRepository
    {
        CrmsystemContext context = new CrmsystemContext();

        public CustomerRepository(CrmsystemContext _context)
        {
            context = _context;
        }

        public Customer CreateCustomer(Customer customer)
        {
            context.Customer.Add(customer);
            context.SaveChanges();
            return new Customer { FirstName = customer.FirstName, Email = customer.Email, JobTitle = customer.JobTitle, City = customer.City, CompanyName = customer.CompanyName, UserId = customer.UserId };
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomerById(id);
            context.Customer.Remove(customer);
            context.SaveChanges();
        }

        public List<Customer> GetAllCustomers()
        {
            return context.Customer.Include(x => x.User).ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return context.Customer.Find(id);
        }

        public Customer GetCustomerByName(string name)
        {
            return context.Customer.FirstOrDefault(x => x.FirstName == name);
        }

        public Customer UpdateCustomer(Customer customer)
        {
            context.Customer.Update(customer);
            context.SaveChanges();
            return customer;
        }
    }
}
