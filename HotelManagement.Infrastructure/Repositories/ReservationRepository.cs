using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Infrastructure.DatabaseContext;

namespace HotelManagement.Infrastructure.Repositories
{
    public class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
