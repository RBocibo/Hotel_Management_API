using HotelManagement.Models;
using MediatR;

namespace HotelManagement.Core.CQRS.Queries
{
    public class GetRoomByIdQuery : IRequest<GetRoomByIdDTO>
    {
        public int RoomId { get; }

        public GetRoomByIdQuery(int roomId)
        {
            RoomId = roomId;
        }
    }
}
