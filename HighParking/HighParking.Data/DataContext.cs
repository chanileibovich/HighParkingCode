using HighParking.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HighParking.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Customer> custommerList { get; set; }
        public DbSet<ParkingDetails> DetailsList { get; set; }
        
        public DbSet<Invoicing> invoicinglist { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=chaniDB");
        }



    }
    
}
