using HotelManagement.Models;
using HotelManagement.Services.ServiceInterfaces;
using MediatR;

namespace HotelManagement.Core.CQRS.Queries
{
    public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, GetRoomByIdDTO>
    {
        private readonly IRoomService _roomService;

        public GetRoomByIdQueryHandler(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<GetRoomByIdDTO> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _roomService.SearchRoomById(request.RoomId);
            return response;
        }
    }
}
