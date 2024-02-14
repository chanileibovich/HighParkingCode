using HighParking.Core.Entities;

namespace HighParking.Core.Services
{
    public interface IDetailsService
    {
        IEnumerable<ParkingDetails> GetAllDetails();

        int GetCountDetails();

        ParkingDetails GetDetailById(int detailsid);
        ParkingDetails AddDetail(ParkingDetails det);

    }
}