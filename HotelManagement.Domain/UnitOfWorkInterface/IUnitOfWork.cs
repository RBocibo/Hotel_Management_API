namespace HotelManagement.Domain.UnitOfWorkInterface
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
