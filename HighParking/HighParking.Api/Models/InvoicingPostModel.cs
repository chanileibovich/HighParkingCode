using HighParking.Core.Entities;

namespace HighParking.Api.Controllers.Models
{
    public class InvoicingPostModel
    {
        public Status CustomerType { get; set; }
        public int CustomerId { get; set; }
        public int ParkingDetailsId { get; set; }

    }
}
