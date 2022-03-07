using AutoMapper;
using HotelListing.Data;
using HotelListing.Models;

namespace HotelListing.Configurations
{
    public class MapperInitialiser : Profile
    {
        public MapperInitialiser()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<CountryDTO, Country>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
            CreateMap<CreateHotelDTO, Hotel>().ReverseMap();
        }
    }
}
