using HighParking.Core.Entities;

namespace HighParking.Core.Repositories
{
    public interface IDetailsRepository
    {
        IEnumerable<ParkingDetails> GetAllDetails();

        int GetCountDetails();

        ParkingDetails GetDetailById(int detailsid);
        ParkingDetails AddDetail(ParkingDetails det);

    }
}
