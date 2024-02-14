using HighParking.Core.Entities;

namespace HighParking.Core.Services
{
    public interface ICustomerervices
    {

        IEnumerable<Customer> GetAllCustomer();

        int GetCountCustomer();

        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer Cust);
        Customer UpdateCustomer(int id, Customer cs);
        Customer DeleteCustomer(int id);

    }
}
