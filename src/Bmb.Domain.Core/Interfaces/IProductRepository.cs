using System.Collections.ObjectModel;
using Bmb.Domain.Core.Entities;
using Bmb.Domain.Core.ValueObjects;

namespace Bmb.Domain.Core.Interfaces;

public interface IProductRepository
{
    Task<Product?> FindByIdAsync(Guid id);

    Task<Product> CreateAsync(Product product);

    Task<bool> DeleteAsync(Guid productId);

    Task<ReadOnlyCollection<Product>> GetAll();

    Task<ReadOnlyCollection<Product>> FindByCategory(ProductCategory category);

    Task<bool> UpdateAsync(Product product);
}
