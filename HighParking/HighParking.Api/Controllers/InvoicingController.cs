using HighParking.Api.Controllers.Models;
using HighParking.Core.Entities;
using HighParking.Data;
using HighParking.Service;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web Api for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HighParking.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class InvoicingController : ControllerBase
    {
        private readonly InvoicingService _invoicingservice;


        public InvoicingController(InvoicingService invoicingservice)
        {
            _invoicingservice = invoicingservice;
        }
        
        // GET: Api/<InvoicingController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_invoicingservice.GetAllInvoicings()); 
        }

        // GET Api/<InvoicingController>/5
        [HttpGet("{id}")]
        public ActionResult<Invoicing> GetById(string id)
        {
            return Ok(_invoicingservice.GetInvoicingById(id));
        }

        // POST Api/<InvoicingController>
        [HttpPost]
        public Invoicing Post([FromBody] InvoicingPostModel inv)
        {
            var invoicing = new Invoicing { CustomerType = inv.CustomerType, CustomerId=inv.CustomerId, ParkingDetailsId=inv.ParkingDetailsId };
            return _invoicingservice.AddInvoicing(invoicing);


    }

        // PUT Api/<InvoicingController>/5
        [HttpPut("{id}")]
        public Invoicing Put(string id, [FromBody] Invoicing inv)
        {
           return _invoicingservice.UpdateInvoicing(inv, id);
        }



    }
}
