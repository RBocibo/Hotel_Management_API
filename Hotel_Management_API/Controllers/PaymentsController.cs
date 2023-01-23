using HotelManagement.Core.CQRS.Commands;
using HotelManagement.Models.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController
    {
        public PaymentsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult<CreatePaymentDTO>> CreatePayment(CreatePaymentDTO createPaymentDTO)
        {
            var command = new CreatePaymentCommand(createPaymentDTO);

            var response = await _mediator.Send(command);

            return Ok(response);    
        }
    }
}
