using Devanshi_Assignment1.Entities;
using Devanshi_Assignment1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devanshi_Assignment1.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly List<customersss> _customerss;

        public CustomerRepo()
        {
            _customerss = new List<customersss>
            {
                new customersss
                {
                    Id = 1, FirstName = "Devanshi",LastName = "Kapadia"
                },
                new customersss
                {
                    Id = 2,  FirstName = "Kesha", LastName = "Sisodia"
                },
                new customersss
                {
                    Id = 3,FirstName = "Mihir ",LastName = "Mashilkar"
                },
                 new customersss
                {
                    Id = 4,FirstName = "Nirav ", LastName = "Savsani"
                }
            };
        }

        public void AddCustomer(customersss customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<customersss> GetAllCustomers() => _customerss;

        public customersss GetCustomerById(int id) => _customerss.FirstOrDefault(c => c.Id == id);

        public bool UpdateCustomer(customersss customer)
        {
            throw new NotImplementedException();
        }
    }
}
