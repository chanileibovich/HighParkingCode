using HighParking.Core.Entities;

namespace HighParking.Data
{
    public class DataContext
    {
        public List<Customers> custommerList { get; set; }
        
        public List<Invoicing> invoicinglist { get; set; }
       

        public DataContext()
        {
            custommerList = new List<Customers>();
            custommerList.Add(new Customers { Id = "000000018", Name = "default name", Email = "default@gmail.com", Phone = "0500000000", Code = 1, Credit = "4580123412341234", Status = Status.regular, Points = 0 });
            
            invoicinglist = new List<Invoicing>();
            invoicinglist.Add(new Invoicing { NumInvoicing = 1, Id = "000000018", Status = Status.regular, Enter = DateTime.Now, Exit = new DateTime(2023, 08, 11, 9, 0, 0), DwellTime = DateTime.Now, Date_ = DateTime.Now, Kindofpayment = Status.regular, total = 1504.25 });
            
    }
}
}
