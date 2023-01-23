using AutoMapper;
using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Domain.UnitOfWorkInterface;
using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;

namespace HotelManagement.Services.Services
{
    public class PaymentService : BaseService, IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper, IUnitOfWork unitOfWork)
            : base(mapper, unitOfWork) 
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<CreatePaymentDTO> MakePayment(CreatePaymentDTO payment)
        {
            var paymentInfo = new Payment
            {
                CustomerId = payment.CustomerId,
                PaymentDate = payment.PaymentDate,
                PaymentType = payment.PaymentType,
            };

            var makePayment = await _paymentRepository.CreateAsync(paymentInfo);
            await _unitOfWork.CommitAsync();

            var mappedPayment = _mapper.Map<CreatePaymentDTO>(makePayment);

            return mappedPayment;
        }
    }
}
