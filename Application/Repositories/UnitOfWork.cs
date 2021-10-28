using Application.Interfaces;
using Domain;

namespace Application.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly StockDbContext context;
    private IProductRepository productRepository = default!;

    public UnitOfWork(StockDbContext context)
    {
        this.context = context;
    }
    public IProductRepository ProductRepository => productRepository ??= new ProductRepository(context);

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}
