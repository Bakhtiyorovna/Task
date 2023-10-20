using Task.Domain.Entities.Storages;

namespace Task.DataAccess.Interfaces.Warehouses;

public interface IWarehouseRepository : IGenericRepository<WarehouseProductDetail>
{
}
