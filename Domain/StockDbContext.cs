using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain;

public class StockDbContext : DbContext
{
    public StockDbContext() { }

    public StockDbContext(DbContextOptions<StockDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; } = default!;
}
