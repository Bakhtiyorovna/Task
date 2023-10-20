namespace Task.Service.DTOs.Warehouses;

public class WarehouseProductCreateDto
{
   // public DateTime LoadCeateTime { get; set; }
    public Guid WarehouseId { get; set; }
    public Guid CategoryId { get; set; }
    public List<Guid> ProductId { get; set; }
    public List<long> Amount { get; set; }
}
