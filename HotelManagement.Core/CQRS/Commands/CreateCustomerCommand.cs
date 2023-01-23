using HotelManagement.Models.DTOs;
using MediatR;

namespace HotelManagement.Core.CQRS.Commands
{
    public class CreateCustomerCommand : IRequest<CreateCustomerDTO>
    {
        public CreateCustomerDTO Model { get; set; }

        public CreateCustomerCommand(CreateCustomerDTO model)
        {
            Model = model;
        }
    }
}
