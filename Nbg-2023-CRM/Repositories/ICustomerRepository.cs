using Nbg_2023_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_2023_CRM.Repositories
{
    public interface ICustomerRepository
    {
        //CRUD
        int CreateCustomer(Customer customer);
        Customer ?ReadCustomer(int id);
        IList<Customer> ReadAllCustomers();
        bool UpdateCustomer(Customer customer, int id);
        bool DeleteCustomer(int id);
    }
}
