namespace Application.Interfaces;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }

    Task<int> SaveAsync();
}
