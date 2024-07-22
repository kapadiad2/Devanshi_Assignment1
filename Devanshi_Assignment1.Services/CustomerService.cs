using AutoMapper;
using Devanshi_Assignment1.Entities;
using Devanshi_Assignment1.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Devanshi_Assignment1.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly ILogger<CustomerService> _logger;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepo customerRepo, ILogger<CustomerService> logger, IMapper mapper)
        {
            _customerRepo = customerRepo;
            _logger = logger;
            _mapper = mapper;
        }

        public List<CustomerDt> GetAllCustomers()
        {
            try
            {
                var customers = _customerRepo.GetAllCustomers();
                return _mapper.Map<List<CustomerDt>>(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting all customers.");
                throw;
            }
        }

        public CustomerDt? GetCustomerById(int id)
        {
            try
            {
                var customer = _customerRepo.GetCustomerById(id);
                return customer != null ? _mapper.Map<CustomerDt>(customer) : null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting customer with ID {id}.", id);
                throw;
            }
        }

        public void AddCustomer(CustomerDt customerDt)
        {
            try
            {
                var customer = _mapper.Map<customersss>(customerDt);
                _customerRepo.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a new customer.");
                throw;
            }
        }

        public bool UpdateCustomer(CustomerDt customerDt)
        {
            try
            {
                var customer = _mapper.Map<customersss>(customerDt);
                return _customerRepo.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating customer with ID {id}.", customerDt.Id);
                throw;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                return _customerRepo.DeleteCustomer(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting customer with ID {id}.", id);
                throw;
            }
        }

        List<customersss> ICustomerService.GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
}