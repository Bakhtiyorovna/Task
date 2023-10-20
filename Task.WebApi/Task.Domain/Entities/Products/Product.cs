using System.ComponentModel.DataAnnotations;

namespace Task.Domain.Entities.Products;

public class Product:Auditable
{
    [MaxLength(20)]
    public string Name { get; set; } = String.Empty;
    public Guid CategoryId { get; set; }
}
