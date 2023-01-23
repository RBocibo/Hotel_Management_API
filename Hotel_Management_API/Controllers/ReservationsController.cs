using HotelManagement.Core.CQRS.Commands;
using HotelManagement.Models.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : BaseController
    {
        public ReservationsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult<CreateReservationDTO>> MakeReservations(CreateReservationDTO createReservationDTO)
        {
            var command = new CreateReservationCommand(createReservationDTO);
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
