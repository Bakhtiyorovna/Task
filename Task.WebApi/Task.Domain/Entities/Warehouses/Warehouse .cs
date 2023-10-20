using System.ComponentModel.DataAnnotations;

namespace Task.Domain.Entities.Storages;

public class Warehouse : Auditable
{
    [MaxLength(20)]
    public string Name { get; set; } = String.Empty;
}
