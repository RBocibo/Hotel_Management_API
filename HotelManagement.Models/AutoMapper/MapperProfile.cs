using AutoMapper;
using HotelManagement.Domain;

namespace HotelManagement.Models.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<GetRoomByIdDTO, Room>().ReverseMap();
        }
    }
}
