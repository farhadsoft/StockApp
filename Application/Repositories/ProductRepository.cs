using Application.Interfaces;
using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly DbSet<Product> dbSet;

    public ProductRepository(StockDbContext context)
    {
        dbSet = context.Set<Product>();
    }
    public async Task AddAsync(IEnumerable<Product> entity)
    {

        await dbSet.AddRangeAsync(entity);
    }

    public void Delete(Product entity)
    {
        dbSet.RemoveRange(entity);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var entity = await dbSet.FindAsync(id);
        if (entity != null)
        {
            this.Delete(entity);
        }
    }

    public IQueryable<Product> FindAll()
    {
        return dbSet.AsNoTracking();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        var result = await dbSet.FindAsync(id);
        return result ?? new Product();
    }

    public void Update(Product entity)
    {
        dbSet.Update(entity);
    }
}
