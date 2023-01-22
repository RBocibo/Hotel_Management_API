using HotelManagement.Domain.UnitOfWorkInterface;
using HotelManagement.Infrastructure.DatabaseContext;

namespace HotelManagement.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelManagementDbContext _context;

        public UnitOfWork(HotelManagementDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
