using HighParking.Core.Entities;
using HighParking.Core.Repositories;

namespace HighParking.Data.Repositories
{
    public class InvoicingRepository:IInvoicingRepository
    {
        private readonly DataContext _context;

        public InvoicingRepository(DataContext context)
        {
            _context = context;
        }
        
        public List<Invoicing> GetAllInvoicings()
        {
            return _context.invoicinglist;
        }

        public Invoicing GetInvoicingById(string id)
        {
            return _context.invoicinglist.First(u => u.Id == id);
        }

        public int GetCountInvoicing()
        {
            int count = _context.invoicinglist.Count;
            return count;
        }

       


    }
}
