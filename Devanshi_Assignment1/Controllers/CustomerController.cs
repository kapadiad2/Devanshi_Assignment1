using AutoMapper;
using Devanshi_Assignment1.Entities;
using Devanshi_Assignment1.Interfaces;
using Devanshi_Assignment1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devanshi_Assignment1.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _custserv;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService cservice, IMapper mapper)
        {
            _custserv = cservice;
            _mapper = mapper;
        }

      


        [HttpGet("{id}")]
        public ActionResult<CustomerDt> GetCustomerById(int id)
        {
            var customerDt = _custserv.GetCustomerById(id);
            return customerDt != null ? Ok(customerDt) : NotFound();
        }





        [HttpGet]
        public ActionResult<IEnumerable<CustomerDt>> GetAllCustomers()
        {
            return Ok(_custserv.GetAllCustomers());
        }


        [HttpPost]
        public IActionResult CreateCustomer(CustomerDt customerDt)
        {
            _custserv.AddCustomer(customerDt);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customerDt.Id }, customerDt);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, CustomerDt customerDt)
        {
            if (id != customerDt.Id)
            {
                return BadRequest(); // Mismatched IDs
            }

            if (!_custserv.UpdateCustomer(customerDt))
            {
                return NotFound(); // Customer not found
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var success = _custserv.DeleteCustomer(id);
            return success ? NoContent() : NotFound();
        }


    }
}
