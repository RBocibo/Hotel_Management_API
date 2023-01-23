using HotelManagement.Models.DTOs;
using MediatR;

namespace HotelManagement.Core.CQRS.Commands
{
    public class CreateReservationCommand : IRequest<CreateReservationDTO>
    {
        public CreateReservationDTO Model { get; set; }

        public CreateReservationCommand(CreateReservationDTO model)
        {
            Model = model;
        }
    }
}
