using HotelManagement.Models.DTOs;

namespace HotelManagement.Services.ServiceInterfaces
{
    public interface ICustomerService 
    {
        Task<CreateCustomerDTO> MakeReservation(CreateCustomerDTO customerMakeReservation);
    }
}
