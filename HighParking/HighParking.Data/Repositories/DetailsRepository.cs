using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HighParking.Data.Repositories
{
    public class DetailsRepository: IDetailsRepository/**/
    {
        private readonly DataContext _context;
        public DetailsRepository(DataContext context)
        {
            _context = context;
        }
        
        public IEnumerable<ParkingDetails> GetAllDetails()
        {
            return _context.DetailsList.Include(x=>x.Invoicing);
        }

        public ParkingDetails GetDetailById(int detailsid)
        {
            return _context.DetailsList.Find(detailsid); 
        }

        public int GetCountDetails()
        {
            int count = _context.DetailsList.ToList().Count;
            return count;
        }

        public ParkingDetails AddDetail(ParkingDetails det)
        {
            _context.DetailsList.Add(det);
            _context.SaveChanges();
            return det;
        }


        

    }
}
