using HotelManagement.Domain.RepositoryInterfaces;
using HotelManagement.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelManagement.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity>  _dbset;
        public BaseRepository(HotelManagementDbContext context)
        {
            _dbset = context.Set<TEntity>();
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            var deleted = _dbset.Where(expression);
            if (deleted == null)
            {
                return;
            }

            _dbset.RemoveRange(deleted);

        }

        public async Task<TEntity> FindByExpression(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await _dbset.FirstOrDefaultAsync(expression);
            return entity;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await _dbset.FirstOrDefaultAsync(expression);
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbset.Update(entity);
            return await Task.FromResult(entity);
        }
    }
}
