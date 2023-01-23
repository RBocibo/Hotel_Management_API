using HotelManagement.Models.DTOs;

namespace HotelManagement.Services.ServiceInterfaces
{
    public interface IPaymentService
    {
        Task<CreatePaymentDTO> MakePayment(CreatePaymentDTO payment);
    }
}
