using HighParking.Core.Entities;
using HighParking.Core.Repositories;

namespace HighParking.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        
        public CustomerRepository(DataContext context)
        {
            _context=context;
        }


        public List<Customers> GetAllCustomers()
        {
            return _context.custommerList;
        }

        public Customers GetCustomerById(string id)
        {
            return _context.custommerList.First(u => u.Id == id);
        }

        public int GetCountCustomer()
        {          
            int count= _context.custommerList.Count;
            return count;
        }





    }
}
