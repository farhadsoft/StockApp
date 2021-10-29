using Application.DTOs;

namespace Application.Interfaces
{
    public interface ISearchService
    {
        Task<ProductSearchDto> GetByNameAsync(string name);
    }
}
