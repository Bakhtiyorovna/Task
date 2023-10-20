using System.ComponentModel.DataAnnotations;

namespace Task.Domain.Entities.Categories;

public class Category:Auditable
{
    [MaxLength(20)]
    public string Name { get; set; } = String.Empty;
}
