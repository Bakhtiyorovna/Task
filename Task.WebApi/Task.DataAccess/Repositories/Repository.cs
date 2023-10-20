using Microsoft.EntityFrameworkCore;
using Task.DataAccess.DbContexts;
using Task.DataAccess.Interfaces;
using Task.Domain.Entities;

namespace Task.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected DbSet<T> _dbSet;

    public Repository(AppDbContext appDb)
    {
        this._dbSet = appDb.Set<T>();
    }

    public void Add(T entity) => this._dbSet.Add(entity);

    public async Task<long> CountAsync()
        => await _dbSet.CountAsync();

    public void Delete(T entity) => this._dbSet?.Remove(entity);

    public async Task<T?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);

    public void Update(Guid id, T entity)
    {
        entity.Id = id;
        this._dbSet.Update(entity);
    }
}


