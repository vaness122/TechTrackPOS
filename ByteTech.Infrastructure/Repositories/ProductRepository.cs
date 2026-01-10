using ByteTech.Core.Interfaces;
using ByteTech.Core.Models;
using ByteTech.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }




        public async Task<Product> AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> BarcodeExistsAsync(string barcode, int? excludeId = null)
        {
            var query = _context.Products.Where(p => p.Barcode == barcode);
            if(excludeId.HasValue) query = query.Where(p => p.Id  != excludeId.Value);
            return await query.AnyAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var product = await GetByIdAsync(id);

            if (product != null) 
            {
             _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetActiveProductAsync()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Where(p => p.IsActive && !p.IsInactive)
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Where(p => p.IsActive)
                .ToListAsync();
        }

        public async Task<Product?> GetByBarCodeAsync(string barCode)
        {
            return await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Barcode == barCode);    
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product?> GetByLookupCodeAsync(string lookupCode)
        {
            return await _context.Products
                  .Include(p => p.Category)
                  .FirstOrDefaultAsync(p => p.LookupCode == lookupCode);
        }

        public async Task<Product?> GetBySKUAsync(string sku)
        {
            return await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.SKU == sku);
        }

        public async Task<IEnumerable<Product>> GetLowStockProductsAsync()
        {
            return await _context.Products
                .Where( p => p.IsActive && p.TrackInventory
                 && p.Stock <= p.MinimumStockLevel)
                .ToListAsync();
        }

        public async Task<bool> LookupCodeExistsAsync(string lookupCode, int? excludeId = null)
        {
            var query = _context.Products.Where(p => p.LookupCode == lookupCode);
            if(excludeId.HasValue) query = query.Where(p => p.Id !=  excludeId.Value);
            return await query.AnyAsync();
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
        {
           return await _context.Products
                .Include(p => p.Category)
                .Where(p => p.IsActive &&
                (p.Name.Contains(searchTerm) ||
                p.LookupCode.Contains(searchTerm) ||
                p.SKU.Contains(searchTerm)))
                .ToListAsync();
                
                
                
        }

        public async Task<bool> SKUExistsAsync(string sku, int? excludeId = null)
        {
           var query = _context.Products.Where(p => p.SKU == sku);
            if(excludeId.HasValue) query = query.Where(p => p.Id != excludeId.Value);
            return await query.AnyAsync();
        }

        public async Task UpdateAsync(Product product)
        {
           _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
