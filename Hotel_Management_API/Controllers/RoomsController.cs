using HotelManagement.Core.CQRS.Queries;
using HotelManagement.Models;
using HotelManagement.Models.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_API.Controllers
{
    [Route("v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
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

        [HttpGet("roomType")]
        public async Task<IEnumerable<GetRoomByRoomTypeDTO>> GetRoomByRoomType(string roomType)
        {
            var query = new GetRoomByRoomTypeQuery(roomType);
            var response = await _mediator.Send(query);
            return response;
        }

        [HttpGet("GetAllRoms")]
        public async Task<IEnumerable<GetAllRoomsDTO>> GetAllRooms()
        {
            var query = new GetAllRoomsQuery();
            var response = await _mediator.Send(query);
            return response;
        }
    }
}
