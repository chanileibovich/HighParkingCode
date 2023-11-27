 using HighParking.Core.Entities;

namespace HighParking.Core.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();

        int GetCountCustomer();

        Customers GetCustomerById(string id);
    }
}
