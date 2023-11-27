using HighParking.Core.Entities;

namespace HighParking.Core.Services
{
    public interface ICustomerServices
    {

        IEnumerable<Customers> GetAllCustomers();
        Customers GetCustomerById(string id);

    }
}
