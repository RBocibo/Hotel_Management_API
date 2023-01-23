using HotelManagement.Models.DTOs;
using MediatR;

namespace HotelManagement.Core.CQRS.Commands
{
    public class CreatePaymentCommand : IRequest<CreatePaymentDTO>
    {
        public CreatePaymentDTO Model { get; set; }

        public CreatePaymentCommand(CreatePaymentDTO model)
        {
            Model = model;
        }
    }
}
