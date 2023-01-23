using HotelManagement.Core.CQRS.Commands;
using HotelManagement.Models.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : BaseController
    {
        public CustomersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<ActionResult<CreateCustomerDTO>> CreateCustomer(CreateCustomerDTO createCustomerDTO)
        {
            var command = new CreateCustomerCommand(createCustomerDTO);
            var response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
