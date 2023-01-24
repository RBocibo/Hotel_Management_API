using AutoMapper;
using HotelManagement.Domain;
using HotelManagement.Models.DTOs;

namespace HotelManagement.Models.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<GetRoomByIdDTO, Room>().ReverseMap();
            CreateMap<CreateCustomerDTO, Customer>().ReverseMap();
            CreateMap<CreateReservationDTO, Reservation>().ReverseMap();
            CreateMap<CreatePaymentDTO, Payment>().ReverseMap();
            CreateMap<GetRoomByRoomTypeDTO, Room>().ReverseMap();
            CreateMap<Room, GetRoomByRoomTypeDTO>().ReverseMap();
            CreateMap<Room, GetAllRoomsDTO>().ReverseMap();
        }
    }
}
