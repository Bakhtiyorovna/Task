using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Task.DataAccess.DbContexts;
using Task.DataAccess.Interfaces;
using Task.Domain.Entities;

namespace Task.DataAccess.Repositories;

public class GenericRepository<TEntity> : Repository<TEntity>,
       IGenericRepository<TEntity> where TEntity : BaseEntity
{
    public GenericRepository(AppDbContext appDb) : base(appDb)
    {

    }

    public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        => await _dbSet.FirstOrDefaultAsync(expression);
    public IQueryable<TEntity> GetAll()
        => _dbSet;
    public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        => _dbSet.LastOrDefaultAsync(expression);
    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        => _dbSet.Where(expression);
}
