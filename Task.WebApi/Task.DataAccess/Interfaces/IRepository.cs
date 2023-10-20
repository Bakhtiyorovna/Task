using Task.Domain.Entities;

namespace Task.DataAccess.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    public Task<long> CountAsync();
    public void Add(T entity);
    public void Update(Guid id, T entity);
    public void Delete(T entity);
    public Task<T?> GetByIdAsync(Guid id);
}

