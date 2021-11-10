using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class Product : BaseEntity
{
    [Required]
    [MaxLength(20)]
    public string Name { get; set; } = default!;

    [MaxLength(20)]
    public string? Seria { get; set; }

    [MaxLength(30)]
    public string? Code { get; set; }

    public int Quantity { get; set; }
}
