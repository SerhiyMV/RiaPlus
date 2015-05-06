using System.Linq;
using RiaPlus.Domain.Entities;

namespace RiaPlus.Domain.Abstract
{
    public interface IProductsRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productId);
    }
}
