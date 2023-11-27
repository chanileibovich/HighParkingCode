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
        private readonly ICustomerServices _icustomersservice;
        private static List<Customers> lstcustomers = new List<Customers>();


        public CustommerController(ICustomerServices customersservice)
        {
            _icustomersservice = customersservice;
        }
        // GET: Api/<CustommerController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_icustomersservice.GetAllCustomers());
        }

        // GET Api/<CustommerController>/5
        [HttpGet("{id}")]
        public ActionResult <Customers> Get(string id)
        {
            var c = _icustomersservice.GetCustomerById(id);
            if(c==null)
            {
                return NotFound();
            }
            return c;
        }

        // POST Api/<CustommerController>
        [HttpPost]
        public ActionResult Post([FromBody] Customers cs)
        {
            if (cs.Id.ToString().Length != 9)
            {
                return BadRequest();
            }
            lstcustomers.Add(new Customers { Id = cs.Id, Name = cs.Name, Phone = cs.Phone, Bit=cs.Bit, Code=cs.Code, Email=cs.Email, Credit=cs.Credit, Points=cs.Points, Status=cs.Status});
            return Ok();
        }

        // PUT Api/<CustommerController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Customers cs)
        {
            Customers c = _icustomersservice.GetCustomerById(id);
            if (c != null)
            {
                c.Name = cs.Name;
                c.Email = cs.Email;
                c.Phone = cs.Phone;
                c.Code = cs.Code;
                c.Credit = cs.Credit;
                c.Status = cs.Status;
                c.Points = cs.Points;
            }

        }

        // DELETE Api/<CustommerController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Customers c = _icustomersservice.GetCustomerById(id);
            if (c != null)
            {
                lstcustomers.Remove(c);
                
            }
        }
    }
}
