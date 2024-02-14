using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using HighParking.Core.Services;
using System.Xml.Linq;

namespace HighParking.Service
{
    public class InvoicingService : IInvoicingService
    {
        private readonly IInvoicingRepository _invoicingRepository;
        public InvoicingService(IInvoicingRepository invoicingRepository)
        {
            _invoicingRepository = invoicingRepository;
        }

        public Invoicing GetInvoicingById(string id)
        {

            return _invoicingRepository.GetInvoicingById(id);
        }

      
        
        public IEnumerable<Invoicing> GetAllInvoicings()
        {
            return _invoicingRepository.GetAllInvoicings();
        }

        public Invoicing UpdateInvoicing(Invoicing Inv, string id)
        {
            return _invoicingRepository.UpdateInvoicing(Inv, id);
        }

        public Invoicing AddInvoicing(Invoicing inv)
        {
            return _invoicingRepository.AddInvoicing(inv);
        }

        public int GetCountInvoicing()
        {
            return _invoicingRepository.GetCountInvoicing();
        }

    }
}
