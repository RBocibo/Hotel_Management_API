using AutoMapper;
using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Domain.UnitOfWorkInterface;
using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;

namespace HotelManagement.Services.Services
{
    public class CustomerService : BaseService, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper, IUnitOfWork unitOfWork)
            : base(mapper, unitOfWork)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CreateCustomerDTO> MakeReservation(CreateCustomerDTO customerMakeReservation)
        {
            //new customer
            var customerDetails = new Customer ()
            {
                CustomerName = customerMakeReservation.CustomerName,
                CustomerLastName = customerMakeReservation.CustomerLastName,
                Address = customerMakeReservation.Address,
                Status = customerMakeReservation.Status,
                ContactNumber = customerMakeReservation.ContactNumber,
                EmailAddress = customerMakeReservation.EmailAddress,
            };

            var addCustomerDetails = await _customerRepository.CreateAsync(customerDetails);
            await _unitOfWork.CommitAsync();

            var mappedCustomerDetails = _mapper.Map<CreateCustomerDTO>(addCustomerDetails);

            return mappedCustomerDetails;
        }
    }
}
