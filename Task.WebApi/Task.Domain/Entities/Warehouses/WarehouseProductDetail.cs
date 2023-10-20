namespace Task.Domain.Entities.Storages;

public class WarehouseProductDetail : Auditable
{
    public DateTime LoadCeateTime { get; set; }
    public Guid WarehouseId  { get; set; }
    public Guid ProductId { get; set; }
    public long Amount { get; set; }
}
