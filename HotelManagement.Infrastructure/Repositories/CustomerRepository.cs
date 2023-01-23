using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Infrastructure.DatabaseContext;

namespace HotelManagement.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
