namespace HighParking.Core.Entities
{
    public class ParkingDetails
    {
        public int Id { get; set; }/*מספור אוטומטי*/
        public DateTime Enter { get; set; }
        public DateTime Exit { get; set; }
        public DateTime DwellTime { get; set; }
        public double Total { get; set; }
        public string Credit { get; set; }
        public string InvoicingId { get; set; }
        public Invoicing Invoicing { get; set; }




    }
}
