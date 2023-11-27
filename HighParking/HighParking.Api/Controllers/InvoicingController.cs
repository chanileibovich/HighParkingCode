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
        private static List<Invoicing> lstinvoicing = new List<Invoicing>();


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
        public ActionResult<Invoicing> Get(string id)
        {
            var inv = _invoicingservice.GetInvoicingById(id);
            if (inv == null)
            {
                return NotFound();
            }
            return inv;
        }

        // POST Api/<InvoicingController>
        [HttpPost]
        public ActionResult Post([FromBody] Invoicing inv)
        {
            lstinvoicing.Add(new Invoicing { Date_=inv.Date_, DwellTime=inv.DwellTime, Enter=inv.Enter, Exit= inv.Exit, Id= inv.Id, Kindofpayment= inv.Kindofpayment, NumInvoicing= inv.NumInvoicing, Status= inv.Status, total= inv.total});           
            return Ok();
            
        }

        // PUT Api/<InvoicingController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Invoicing inv)
        {
            Invoicing i = _invoicingservice.GetInvoicingById(id);
            if (i != null)
            {
                i.Status = inv.Status;
                i.Enter = inv.Enter;
                i.Exit = inv.Exit;
                i.DwellTime = inv.DwellTime;
                i.Date_ = inv.Date_;
                i.Kindofpayment = inv.Kindofpayment;
                i.total = inv.total;

            }
        }

        // DELETE Api/<InvoicingController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Invoicing i = _invoicingservice.GetInvoicingById(id);
            if (i != null)
            {
                lstinvoicing.Remove(i);
            }
        }
    }
}
