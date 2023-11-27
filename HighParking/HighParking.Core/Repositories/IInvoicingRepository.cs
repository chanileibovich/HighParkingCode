
using HighParking.Core.Entities;

namespace HighParking.Core.Repositories
{
    public interface IInvoicingRepository
    {

        List<Invoicing> GetAllInvoicings();

        int GetCountInvoicing();

        Invoicing GetInvoicingById(string id);

    }
}
