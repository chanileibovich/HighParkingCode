namespace HighParking.Core.Entities { 
    public class Invoicing
    {

        public enum KindOfPayment
        {
            Married, Single,
        }

        public int NumInvoicing { get; set; }
        public string Id { get; set; }
        public Status Status { get; set; }
        public DateTime Enter { get; set; }
        public DateTime Exit { get; set; }
        public DateTime DwellTime { get; set; }
        public DateTime Date_ { get; set; }
        public Status Kindofpayment { get; set; }
        public double total { get; set; }





    }
}
