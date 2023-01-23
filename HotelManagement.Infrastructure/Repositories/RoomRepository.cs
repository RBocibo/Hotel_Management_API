using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Infrastructure.DatabaseContext;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomRepository : BaseRepository<Room>, IRoomInterface
    {
        public RoomRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
