using Task.DataAccess.DbContexts;
using Task.DataAccess.Interfaces;
using Task.DataAccess.Interfaces.Warehouses;
using Task.DataAccess.Repositories.Warehouses;

namespace Task.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private AppDbContext appDbContext;
    public IWarehouseRepository WarehouseProductDetail { get; }

    public UnitOfWork(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
        this.WarehouseProductDetail = new WarehouseRepository(appDbContext);
    }

    public async Task<int> SaveChangesAsycn()
        => await this.appDbContext.SaveChangesAsync();
}
