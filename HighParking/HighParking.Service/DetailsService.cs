using HighParking.Core.Entities;
using HighParking.Core.Repositories;
using HighParking.Core.Services;

namespace HighParking.Service
{
    public class DetailsService: IDetailsService
    {
        private readonly IDetailsRepository _detailsRepository;/**/
        public DetailsService(IDetailsRepository detailsRepository)
        {
            _detailsRepository = detailsRepository;
        }

        public ParkingDetails GetDetailById(int detailsid)
        {

            return _detailsRepository.GetDetailById(detailsid);

        }


        public IEnumerable<ParkingDetails> GetAllDetails()
        {
            return _detailsRepository.GetAllDetails();
        }

        public ParkingDetails AddDetail(ParkingDetails det)
        {
            return _detailsRepository.AddDetail(det);
        }
        
        
        public int GetCountDetails()
        {
            return _detailsRepository.GetCountDetails();
        }

        

        
        

    }
}
