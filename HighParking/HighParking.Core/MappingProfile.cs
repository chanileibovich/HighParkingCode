using AutoMapper;
using HighParking.Core.DTOs;
using HighParking.Core.Entities;

namespace HighParking.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();

        }

    }
}
