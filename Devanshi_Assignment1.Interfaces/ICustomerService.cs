using Devanshi_Assignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devanshi_Assignment1.Interfaces
{
    public interface ICustomerService
    {
        List<customersss> GetAllCustomers();
       
        CustomerDt? GetCustomerById(int id);
        void AddCustomer(CustomerDt customerDt);
        bool UpdateCustomer(CustomerDt customerDt);
        bool DeleteCustomer(int id);
    }
}
