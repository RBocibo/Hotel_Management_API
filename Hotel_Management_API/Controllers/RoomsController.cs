using HotelManagement.Core.CQRS.Queries;
using HotelManagement.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : BaseController
    {
        public RoomsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<GetRoomByIdDTO> GetRoomById(int roomId)
        {
            var query = new GetRoomByIdQuery(roomId);
            var response = await _mediator.Send(query);
            return response;
        }
    }
}
