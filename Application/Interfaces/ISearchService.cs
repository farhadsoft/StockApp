using Application.DTOs;

namespace Application.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<ProductSearchDto>> GetByNameAsync(string name);
        Task<IEnumerable<ProductNameDto>> GetAllNames();
    }
}
