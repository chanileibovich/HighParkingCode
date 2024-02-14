using HighParking.Core.DTOs;
using HighParking.Core.Entities;

namespace HighParking.Core
{
    public class Mapping
    {
        public CustomerDto MapToCustomerDto(Customer customer)
        {

            return new CustomerDto { Id = customer.Id, StrId = customer.StrId, Name = customer.Name,
                Email = customer.Email, Phone = customer.Phone, Code = customer.Code,
                Credit = customer.Credit, Status = customer.Status, Points = customer.Points };
        }
    }
}
