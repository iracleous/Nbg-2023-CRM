using Nbg_2023_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_2023_CRM.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private  readonly List<Customer> customers 
            = new List<Customer>();
        private int index;
          public int CreateCustomer(Customer customer)
        {
            customers.Add(customer);
            customer.Id = ++index;
            return index;
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        //  code with hazards
        public IList<Customer> ReadAllCustomers()
        {
           return customers.AsReadOnly();
        }

        public Customer? ReadCustomer(int id)
        {
            //return customers
            //     .Where(cust => cust.Id == id)
            //     .FirstOrDefault();
            foreach (Customer customer in customers)
            {
                if (customer.Id == id) {
                    return customer;
                }
            }
            return null;
        }

        public bool UpdateCustomer(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}
