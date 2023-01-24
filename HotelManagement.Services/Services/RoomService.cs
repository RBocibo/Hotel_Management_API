using HotelManagement.Models;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Services.ServiceInterfaces;
using AutoMapper;
using HotelManagement.Domain.UnitOfWorkInterface;
using HotelManagement.Models.DTOs;

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

        public async Task<IEnumerable<GetAllRoomsDTO>> GetAllRooms()
        {
            var rooms = await _roomInterface.GetAllAsync();

            var mappedRooms = _mapper.Map<IEnumerable<GetAllRoomsDTO>>(rooms);
            return mappedRooms;
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

        public async Task<IEnumerable<GetRoomByRoomTypeDTO>> SearchRoomByRoomType(string roomType)
        {
            var room = await _roomInterface.FindByExpression(x => x.RoomType == roomType);

            if(room == null)
            {
                return null;
            }

            var mappedRoom = _mapper.Map<IEnumerable<GetRoomByRoomTypeDTO>>(room);

            return mappedRoom;
        }
    }
}
