using System.Linq.Expressions;

namespace HotelManagement.Domain.RepositoryInterfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task DeleteAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> expression);
        Task<List<TEntity>> GetAllAsync();
    }
}
