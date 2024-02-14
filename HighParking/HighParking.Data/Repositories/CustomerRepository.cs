using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HighParking.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        
        public CustomerRepository(DataContext context)
        {
            _context=context;
        }


        public IEnumerable<Customer> GetAllCustomer()
        {
            return _context.custommerList;
        }

        public Customer GetCustomerById(int id)
        {
            return _context.custommerList.Find(id);
        }

        public int GetCountCustomer()
        {          
            int count= _context.custommerList.ToList().Count;
            return count;
        }
        public Customer AddCustomer(Customer Cust)
        {
            _context.custommerList.Add(Cust);
            _context.SaveChanges();
            return Cust;
        }

        public Customer UpdateCustomer(int id,Customer cs)
        {
            _context.SaveChanges();
            return cs;
        }
        public Customer DeleteCustomer(int id)
        {
            Customer c= GetCustomerById(id);
            _context.custommerList.Remove(c);
            _context.SaveChanges();
            return c;
        }





    }
}
