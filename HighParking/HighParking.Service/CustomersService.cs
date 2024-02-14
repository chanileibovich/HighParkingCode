using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using HighParking.Core.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HighParking.Service
{
    public class CustomerService : ICustomerervices
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return _customerRepository.GetAllCustomer();
        }
        //public IEnumerable<Customer> GetAllCustomer(string? name = "")
        //{
        //    //TODO business logic - לוגיקה עסקית
        //    return _customerRepository.GetAllCustomer().Where(u=>u.Name.StartsWith(name));
            
        //}

        public int GetCountCustomer()
        {
           return _customerRepository.GetCountCustomer();
        }

        public Customer AddCustomer(Customer Cust)
        {
            return _customerRepository.AddCustomer(Cust);
        }

        public Customer UpdateCustomer(int id, Customer cs)
        {
            return _customerRepository.UpdateCustomer(id, cs);
        }

        public Customer DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

      
             
        
        

    }
}
