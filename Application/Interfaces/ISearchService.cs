using Application.DTOs;

namespace Application.Interfaces
{
    public interface ISearchService
    {
        Task<ProductAddDto> GetByNameAsync(string name);
    }
}
