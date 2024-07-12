using Devanshi_Assignment1.Entities;
using Devanshi_Assignment1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devanshi_Assignment1.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _cRepo;

        public CustomerService(ICustomerRepo cRepo)
        {
            _cRepo = cRepo;
        }

        public List<customersss> GetAllCustomers() => _cRepo.GetAllCustomers();

        public customersss GetCustomerById(int id) => _cRepo.GetCustomerById(id);
    }
}
