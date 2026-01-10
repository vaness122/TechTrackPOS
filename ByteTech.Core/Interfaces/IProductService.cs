using ByteTech.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Interfaces
{
    public interface IProductService
    {
     Task ValidateProductAsync (Product product);
     Task <Product> CreateProductAsync(Product product);
     Task <Product> UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task<Product?> GetProductByIdAsync(int id);

        Task<IEnumerable<Product>> GetLowStockProductAsync();
        Task<IEnumerable<Product>> GetActiveProductAsync();

        Task<Product?> GetProductByLookupCodeAsync(string lookupCode);
        Task< Product?> GetProductByBarCodeAsync(string barCode);
        Task<Product?> GetProductBySKUAsync(string sku);



        Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm);
        Task<IEnumerable<Product>> GetAllProductsAsync();












    }
}
