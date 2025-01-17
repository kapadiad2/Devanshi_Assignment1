﻿using Devanshi_Assignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devanshi_Assignment1.Interfaces
{
    public interface ICustomerRepo
    {
        List<customersss> GetAllCustomers();
        customersss? GetCustomerById(int id);
        void AddCustomer(customersss customer);
        bool UpdateCustomer(customersss customer);
        bool DeleteCustomer(int id);
    }
}
