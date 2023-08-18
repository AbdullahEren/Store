using Entities.Models

namespace Repositories.Contracts
{
    public interface IProductRepository : IProductBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
    }
}