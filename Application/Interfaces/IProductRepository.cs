using Domain.Model;

namespace Application.Interfaces;

public interface IProductRepository : IRepositoryBase<Product>
{
    Task<IQueryable<Product>> GetNamesAsync();
}
