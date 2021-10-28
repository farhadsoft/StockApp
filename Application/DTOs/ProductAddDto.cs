namespace Application.DTOs;

public class ProductAddDto
{
    public string Name { get; set; } = default!;
    public string? Seria { get; set; }
    public string? Code { get; set; }
    public int Quantity { get; set; }
}
