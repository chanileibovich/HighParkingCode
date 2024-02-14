namespace HighParking.Core.Entities { 
    public class Invoicing
    {

        public int Id { get; set; }
        public Status CustomerType { get; set; }  
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ParkingDetailsId { get; set; }
        public ParkingDetails ParkingDetails { get; set; }





    }
}
