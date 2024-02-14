 using HighParking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace HighParking.Core.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomer();

        int GetCountCustomer();

        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer Cust);
        Customer UpdateCustomer(int id, Customer cs);
        Customer DeleteCustomer(int id);
    }
}
