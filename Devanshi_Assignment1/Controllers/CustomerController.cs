using Devanshi_Assignment1.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devanshi_Assignment1.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _custserv;

        public CustomerController(ICustomerService cservice)
        {
            _custserv = cservice;
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _custserv.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet("GetAllCustomers")]

        public IActionResult GetAllCustomers()
        {
            return Ok(_custserv.GetAllCustomers());
        }



    }
}
