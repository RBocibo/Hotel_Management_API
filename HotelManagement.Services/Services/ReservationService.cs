using AutoMapper;
using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Domain.UnitOfWorkInterface;
using HotelManagement.Models.DTOs;
using HotelManagement.Services.ServiceInterfaces;

namespace HotelManagement.Services.Services
{
    public class ReservationService : BaseService, IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        public ReservationService(IReservationRepository reservationRepository, IMapper mapper, IUnitOfWork unitOfWork)
            : base(mapper, unitOfWork)
        {
            _reservationRepository = reservationRepository;
        }
        public async Task<CreateReservationDTO> CreateReservations(CreateReservationDTO createReservation)
        {
            var reservation = new Reservation
            {
                CustomerId = createReservation.CustomerId,
                RoomId= createReservation.RoomId,
                ReservationDate= createReservation.ReservationDate,
                DateIn = createReservation.DateIn,
                DateOut= createReservation.DateOut,
                DaysRange= createReservation.DaysRange,

            };

            var createdReservation = await _reservationRepository.CreateAsync(reservation);
            await _unitOfWork.CommitAsync();

            var mappedReservation = _mapper.Map<CreateReservationDTO>(createdReservation);

            return mappedReservation;

        }
    }
}
