using AutoMapper;
using HighParking.Api.Controllers.Models;
using HighParking.Core;
using HighParking.Core.DTOs;
using HighParking.Core.Entities;
using HighParking.Core.Services;
using HighParking.Data;
using HighParking.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;


// For more information on enabling Web Api for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HighParking.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CustommerController : ControllerBase
    {
        private readonly ICustomerervices _iCustomerservice;
        private readonly Mapping _mapping;
        private readonly IMapper _mapper;

        public CustommerController(ICustomerervices Customerservice, Mapping mapping, IMapper mapper)
        {
            _iCustomerservice = Customerservice;
            _mapping = mapping;
            _mapper = mapper;
        }
        // GET: Api/<CustommerController>
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_iCustomerservice.GetAllCustomer());
        }

        // GET Api/<CustommerController>/5
        [HttpGet("{id}")]
        public Customer GetById(int id)
        {
            return _iCustomerservice.GetCustomerById(id);
            
        }

        // POST Api/<CustommerController>
        [HttpPost]
        public ActionResult Post([FromBody] CustomerPostModel cs)
        {
            var cust = new Customer { StrId = cs.StrId, Name=cs.Name, Email=cs.Email, Phone=cs.Phone, Code=(int)cs.Code, Credit=cs.Credit, Status=cs.Status, Points=cs.Points };
            var custtoadd = _iCustomerservice.AddCustomer(cust);
            var customerdto = _mapper.Map<CustomerDto>(custtoadd);
            return Ok(customerdto);


    }

        // PUT Api/<CustommerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer cs)
        {
            var cust = _iCustomerservice.GetCustomerById(id);
            if (cust is null)
            {
                return NotFound();
            }
            _mapper.Map(cs, cust);
            return Ok(_iCustomerservice.UpdateCustomer(id, cust));
        }

        // DELETE Api/<CustommerController>/5
        [HttpDelete("{id}")]
        public Customer Delete(int id)
        {
           return _iCustomerservice.DeleteCustomer(id);
        }


    }
}
