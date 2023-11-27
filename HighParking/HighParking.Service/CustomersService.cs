using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using HighParking.Core.Services;

namespace HighParking.Service
{
    public class CustomersService : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomersService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public Customers GetCustomerById(string id)
        {
            return _customerRepository.GetAllCustomers().First(u => u.Id == id);
        }

        public IEnumerable<Customers> GetAllCustomers()
        {

            return _customerRepository.GetAllCustomers();

        }
        public IEnumerable<Customers> GetCustomers(string? name = "")
        {
            //TODO business logic - לוגיקה עסקית
            return _customerRepository.GetAllCustomers().Where(u=>u.Name.StartsWith(name));
            
        }

        public int GetCountCustomer()
        {
            int count = _customerRepository.GetCountCustomer();
            return count;
        }

    }
}
