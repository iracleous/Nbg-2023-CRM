using Nbg_2023_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_2023_CRM.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private  readonly List<Customer> customers 
            = new List<Customer>();
        private int index;
          public int Create(Customer customer)
        {
            customers.Add(customer);
            customer.Id = ++index;
            return index;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        //  code with hazards
        public IList<Customer> ReadAll()
        {
           return customers.AsReadOnly();
        }

        public Customer? Read(int id)
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

        public bool Update(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}
