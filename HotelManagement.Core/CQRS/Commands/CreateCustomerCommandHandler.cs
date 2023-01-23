using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;
using MediatR;

namespace HotelManagement.Core.CQRS.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerDTO>
    {
        private readonly ICustomerService _customerService;
        public CreateCustomerCommandHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<CreateCustomerDTO> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await _customerService.MakeReservation(request.Model);

            return response;
        }
    }
}
