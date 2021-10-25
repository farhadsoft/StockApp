using System.ComponentModel.DataAnnotations;

namespace Domain.Model;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
}
