using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetProductAsync(string? brand, string? type, string? sort);

        Task<IReadOnlyList<string>> GetBrandsAsync();
        Task<IReadOnlyList<string>> GetTypesAsync();
        Task<Product?> GetProductByIdAsync(int id);

        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        bool ProductExists(int id);
        Task<bool> SaveChangesAsync();
    }
}