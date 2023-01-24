using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;
using MediatR;

namespace HotelManagement.Core.CQRS.Queries
{
    public class GetRoomByRoomTypeQueryHandler : IRequestHandler<GetRoomByRoomTypeQuery, IEnumerable<GetRoomByRoomTypeDTO>>
    {
        private readonly IRoomService _roomService;

        public GetRoomByRoomTypeQueryHandler(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<IEnumerable<GetRoomByRoomTypeDTO>> Handle(GetRoomByRoomTypeQuery request, CancellationToken cancellationToken)
        {
            var response = await _roomService.SearchRoomByRoomType(request.RoomType);
            return response;
        }
    }
}
