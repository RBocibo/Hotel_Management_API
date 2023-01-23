using HotelManagement.Models.DTOs;

namespace HotelManagement.Services.ServiceInterfaces
{
    public interface IReservationService
    {
        Task<CreateReservationDTO> CreateReservations(CreateReservationDTO createReservation);
    }
}
