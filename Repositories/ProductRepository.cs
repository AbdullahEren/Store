using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }
        public IQueryable<ProductRepository> GetAllProducts(bool trackChanges) => FindAll(trackChanges);
        {
            throw new NotImplementedException();
        }
    }
}