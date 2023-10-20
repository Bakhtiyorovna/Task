using Task.Service.DTOs.Warehouses;

namespace Task.Service.Interfaces.Warehouses;

public interface IWarehouseProductDetailService
{
    public Task<bool> CreateAsync(WarehouseProductCreateDto dto);
}
