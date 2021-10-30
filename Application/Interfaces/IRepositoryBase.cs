using Domain.Model;

namespace Application.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> FindAll();

    Task<TEntity> GetByNameAsync(string name);

    Task AddAsync(IEnumerable<TEntity> entity);

    void Delete();
}
