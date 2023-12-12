using AutoMapper;
using Final.Dto;
using Final.Models;

namespace Final.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Country, CountryDto>();
            CreateMap<Company, CompanyDto>();
            CreateMap<Contact, ContactDto>();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Company, CompanyDto>().ReverseMap();

        }
    }
}
