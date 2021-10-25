using Domain.Model;

namespace Application.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
{
    IQueryable<TEntity> FindAll();

    Task<TEntity> GetByIdAsync(int id);

    Task AddAsync(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    Task DeleteByIdAsync(int id);
}
