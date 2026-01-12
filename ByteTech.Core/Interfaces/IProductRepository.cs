using ByteTech.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Core.Interfaces
{
   public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<Product?> GetByLookupCodeAsync(string lookupCode);
        Task<Product?> GetByBarCodeAsync(string barCode);
        Task<Product?> GetBySKUAsync(string sku);
        Task<bool> LookupCodeExistsAsync(string lookupCode, int? excludeId = null);
        Task<bool> SKUExistsAsync(string sku, int? excludeId = null);
        Task<bool> BarcodeExistsAsync(string barcode, int? excludeId = null);
        Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm);

        Task<IEnumerable<Product>> GetActiveProductAsync();
        Task<IEnumerable<Product>> GetLowStockProductsAsync();

    }
}
