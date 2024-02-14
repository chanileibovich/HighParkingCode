using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HighParking.Data.Repositories
{
    public class InvoicingRepository:IInvoicingRepository
    {
        private readonly DataContext _context;

        public InvoicingRepository(DataContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Invoicing> GetAllInvoicings()
        {
            return _context.invoicinglist.Include(u => u.Customer);
           
        }

        public Invoicing GetInvoicingById(string id)
        {
            return _context.invoicinglist.Find(id);
        }

        public int GetCountInvoicing()
        {
            int count = _context.invoicinglist.ToList().Count;
            return count;
        }

        public Invoicing AddInvoicing(Invoicing Inv)
        {
            _context.invoicinglist.Add(Inv);
            _context.SaveChanges();
            return Inv;
        }

        public Invoicing UpdateInvoicing(Invoicing inv, string id)
        {
            Invoicing i = GetInvoicingById(id);
            if (inv == null)
            {
                i.CustomerType = inv.CustomerType;
            }           
            _context.SaveChanges();
            return i;
        }



    }
}
