using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class Product : BaseEntity
{
    [Required]
    public string Name { get; set; } = default!;
    public string? Seria { get; set; }
    public string? Code { get; set; }
    public int Quantity { get; set; }
}
