
using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;
using MediatR;

namespace HotelManagement.Core.CQRS.Commands
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, CreateReservationDTO>
    {
        private readonly IReservationService _reservationService;

        public CreateReservationCommandHandler(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        public async Task<CreateReservationDTO> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var response = await _reservationService.CreateReservations(request.Model);

            return response;
        }
    }
}
