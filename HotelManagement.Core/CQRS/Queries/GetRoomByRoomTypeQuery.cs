using HotelManagement.Models.DTOs;
using MediatR;

namespace HotelManagement.Core.CQRS.Queries
{
    public class GetRoomByRoomTypeQuery : IRequest<IEnumerable<GetRoomByRoomTypeDTO>>
    {
        public string RoomType { get; set; }

        public GetRoomByRoomTypeQuery(string roomType)
        {
            RoomType = roomType;
        }
    }
}
