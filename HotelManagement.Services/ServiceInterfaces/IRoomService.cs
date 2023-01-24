using HotelManagement.Models;
using HotelManagement.Models.DTOs;

namespace HotelManagement.Services.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<GetRoomByIdDTO> SearchRoomById(int roomId);
        Task<IEnumerable<GetRoomByRoomTypeDTO>> SearchRoomByRoomType(string roomType);
        Task<IEnumerable<GetAllRoomsDTO>> GetAllRooms();
    }
}
