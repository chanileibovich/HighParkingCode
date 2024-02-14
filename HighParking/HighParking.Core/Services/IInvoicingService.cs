using HighParking.Core.Entities;


namespace HighParking.Core.Services
{
    public interface IInvoicingService
    {
        IEnumerable<Invoicing> GetAllInvoicings();

        Invoicing GetInvoicingById(string id);

        Invoicing UpdateInvoicing(Invoicing Inv, string id);
    }
}
