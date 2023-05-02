using Nbg_2023_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_2023_CRM.Services
{
    public interface ICrmService
    {
        Customer CreateCustomer(Customer customer);
        List<Customer> GetAll();
    }
}
