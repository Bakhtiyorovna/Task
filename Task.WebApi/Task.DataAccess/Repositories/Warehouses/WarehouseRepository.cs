using System.Linq.Expressions;
using Task.DataAccess.DbContexts;
using Task.DataAccess.Interfaces.Warehouses;
using Task.Domain.Entities.Storages;

namespace Task.DataAccess.Repositories.Warehouses;

public class WarehouseRepository : GenericRepository<WarehouseProductDetail>, IWarehouseRepository
{
    public WarehouseRepository(AppDbContext appDb) : base(appDb)
    {
    }
}
