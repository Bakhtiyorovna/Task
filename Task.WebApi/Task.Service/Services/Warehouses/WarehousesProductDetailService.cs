using Task.DataAccess.Interfaces;
using Task.Domain.Entities.Storages;
using Task.Service.DTOs.Warehouses;
using Task.Service.Interfaces.Warehouses;

namespace Task.Service.Services.Warehouses;

public class WarehousesProductDetailService : IWarehouseProductDetailService
{
    private readonly IUnitOfWork _unitOfWork;
    private const int TimeConstans = 5;
    public WarehousesProductDetailService( IUnitOfWork unitOfWork)
    {
            this._unitOfWork=unitOfWork;
    }
    public async Task<bool> CreateAsync(WarehouseProductCreateDto dto)
    {
        int count = dto.ProductId.Count();
        int index = 0;
        int temp = 0;
        var dtTime = DateTime.UtcNow;
        dtTime.AddHours(TimeConstans);
        foreach (var item in dto.ProductId)
        {
            WarehouseProductDetail detail = new WarehouseProductDetail()
            {
                WarehouseId = dto.WarehouseId,
                ProductId = dto.ProductId[index],
                Amount = dto.Amount[index],
                LoadCeateTime= dtTime.AddHours(TimeConstans),
                CreatedAt = dtTime.AddHours(TimeConstans),
                UpdatedAt = dtTime.AddHours(TimeConstans)
            };

            index++;
            _unitOfWork.WarehouseProductDetail.Add(detail);

            int result = await _unitOfWork.SaveChangesAsycn();
            temp += result;
        }

        return count == index && count == temp;
    }
}
