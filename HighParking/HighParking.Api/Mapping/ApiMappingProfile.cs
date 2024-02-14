using AutoMapper;
using HighParking.Api.Controllers.Models;
using HighParking.Core.DTOs;
using HighParking.Core.Entities;


namespace HighParking.Api.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<CustomerPostModel, Customer>();

        }
    }
}
