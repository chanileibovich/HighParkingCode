
using HighParking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HighParking.Core.Repositories
{
    public interface IInvoicingRepository
    {

        IEnumerable<Invoicing> GetAllInvoicings();

        int GetCountInvoicing();

        Invoicing GetInvoicingById(string id);
        Invoicing AddInvoicing(Invoicing Inv);
        Invoicing UpdateInvoicing(Invoicing Inv, string id);

    }
}
