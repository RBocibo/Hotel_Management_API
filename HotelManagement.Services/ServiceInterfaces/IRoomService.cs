using HotelManagement.Models;

namespace HotelManagement.Services.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<GetRoomByIdDTO> SearchRoomById(int roomId);
    }
}
