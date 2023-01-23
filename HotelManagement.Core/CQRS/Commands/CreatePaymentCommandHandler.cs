using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;
using MediatR;

namespace HotelManagement.Core.CQRS.Commands
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, CreatePaymentDTO>
    {
        private readonly IPaymentService _paymentService;

        public CreatePaymentCommandHandler(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public async Task<CreatePaymentDTO> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            var response = await _paymentService.MakePayment(request.Model);
            return response;
        }
    }
}
