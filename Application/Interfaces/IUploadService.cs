using Application.DTOs;

namespace Application.Interfaces;

public interface IUploadService
{
    Task AddAsync(IEnumerable<ProductAddDto> products);
}
