using Nbg_2023_CRM.Models;
using Nbg_2023_CRM.Repositories;
using Nbg_2023_CRM.Services;


// comment
// comment 2
// cc33

var customer1 = new Customer { Id = 2, Name = "Dimitris", Address = "Athens" };
var customer2 = new Customer { Id = 2, Name = "Maria", Address = "Patra" };

var customerRepository = new CustomerRepository();

var crmService1 = new CrmService(customerRepository);  
var crmService2 = new CrmService(customerRepository);

crmService1.CreateCustomer(customer1);
crmService2.CreateCustomer(customer2);
foreach (Customer customerIter in crmService1.GetAll())
{
     Console.WriteLine($"Name = {customerIter.Name}  Address = {customerIter.Address}");
};

Console.WriteLine("------------------------");
foreach (Customer customerIter in crmService2.GetAll())
{
    Console.WriteLine($"Name = {customerIter.Name}  Address = {customerIter.Address}");
};

