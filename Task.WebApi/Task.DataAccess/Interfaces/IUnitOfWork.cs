using Task.DataAccess.Interfaces.Warehouses;

namespace Task.DataAccess.Interfaces;

public interface IUnitOfWork
{
    public IWarehouseRepository WarehouseProductDetail { get; }
    public Task<int> SaveChangesAsycn();
}
