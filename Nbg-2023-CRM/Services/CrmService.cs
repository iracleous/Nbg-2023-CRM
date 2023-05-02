using Nbg_2023_CRM.Models;
using Nbg_2023_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbg_2023_CRM.Services
{
    public class CrmService:ICrmService
    {
        private readonly ICustomerRepository _crmRepository;
      

         public CrmService(ICustomerRepository crmRepository)
         {
           _crmRepository = crmRepository;
       }

        public Customer CreateCustomer(Customer customer)
        {
            _crmRepository.CreateCustomer(customer);
            return customer;
        }

        public List<Customer> GetAll()
        {
           return _crmRepository.ReadAllCustomers().ToList();
        }
    }
}
