using HighParking.Core.Entities;

namespace HighParking.Api.Controllers.Models
{
    public class DetailsPostModel
    {
        public DateTime Enter { get; set; }
        public DateTime Exit { get; set; }
        public DateTime DwellTime { get; set; }
        public double Total { get; set; }
        public string Credit { get; set; }
        public string InvoicingId { get; set; }

    }
}
