using HotelManagement.Domain;
using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Infrastructure.DatabaseContext;

namespace HotelManagement.Infrastructure.Repositories
{
    public class PaymentRepository : BaseRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(HotelManagementDbContext context) : base(context)
        {
        }
    }
}
