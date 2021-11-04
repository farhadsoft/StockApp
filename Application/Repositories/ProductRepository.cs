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

    public void Delete()
    {
        dbSet.RemoveRange(dbSet);
    }

    public IQueryable<Product> FindAll()
    {
        return dbSet.AsNoTracking();
    }

    public async Task<IQueryable<Product>> GetByNameAsync(string name)
    {
        var result = await FindAll().Where(x => x.Name == name).ToListAsync();
        return result.AsQueryable();
    }

    public async Task<IQueryable<Product>> GetNamesAsync()
    {
        var result = await FindAll().ToListAsync();
        return result.AsQueryable();
    }
}
