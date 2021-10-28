namespace Application.DTOs
{
    public class ProductSearchDto
    {
        public string Name { get; set; } = default!;
        public string? Seria { get; set; }
        public int Quantity { get; set; }
    }
}
