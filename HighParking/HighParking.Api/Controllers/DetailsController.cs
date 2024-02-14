using HighParking.Api.Controllers.Models;
using HighParking.Core.Entities;
using HighParking.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HighParking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        private readonly DetailsService _detailsservice;/**/
        public DetailsController(DetailsService detailsservice)
        {
            _detailsservice = detailsservice;
        }


        // GET: api/<DetailController>
        [HttpGet]
        public ActionResult GetAllDetails()
        {
            return Ok(_detailsservice.GetAllDetails());/**/
        }

       

        // GET api/<DetailController>/5
        [HttpGet("{id}")]
        public ActionResult<ParkingDetails> GetDetailById(int detailsid)
        {
            return Ok(_detailsservice.GetDetailById(detailsid));
        }


        // POST api/<DetailController>
        [HttpPost]
        public ParkingDetails AddDetail([FromBody] DetailsPostModel det)
        {
            var details = new ParkingDetails {Enter=det.Enter, Exit=det.Exit, DwellTime = det.DwellTime, Total = det.Total, Credit = det.Credit, InvoicingId = det.InvoicingId };
            
            return _detailsservice.AddDetail(details);


    }

     



    }
}
