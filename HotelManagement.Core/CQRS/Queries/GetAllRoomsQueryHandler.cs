using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;
using MediatR;

namespace HotelManagement.Core.CQRS.Queries
{
    public class GetAllRoomsQueryHandler : IRequestHandler<GetAllRoomsQuery, IEnumerable<GetAllRoomsDTO>>
    {
        private readonly IRoomService _roomService;

        public GetAllRoomsQueryHandler(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<IEnumerable<GetAllRoomsDTO>> Handle(GetAllRoomsQuery request, CancellationToken cancellationToken)
        {
            var getRooms = await _roomService.GetAllRooms();

            return getRooms;
        }
    }
}
