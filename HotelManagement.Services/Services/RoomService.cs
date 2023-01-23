using HotelManagement.Models;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Services.ServiceInterfaces;
using AutoMapper;
using HotelManagement.Domain.UnitOfWorkInterface;

namespace HotelManagement.Services.Services
{
    public class RoomService : BaseService, IRoomService
    {
        private readonly IRoomInterface _roomInterface;

        public RoomService(IRoomInterface roomInterface, IMapper mapper, IUnitOfWork unitOfWork)
            :base(mapper, unitOfWork)
        {
            _roomInterface = roomInterface;
        }

        public async Task<GetRoomByIdDTO> SearchRoomById(int roomId)
        {
            var room = await _roomInterface.GetByIdAsync(x => x.RoomId == roomId);

            if(room == null)
            {
                return null;
            }

            var mappedResponse = _mapper.Map<GetRoomByIdDTO>(room);

            return mappedResponse;
        }
    }
}
