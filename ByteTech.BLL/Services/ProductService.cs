using ByteTech.Core.Interfaces;
using ByteTech.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteTech.BAL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            await ValidateProductAsync(product);
            product.DateCreated = DateTime.Now;
            product.IsActive = true;
            return await _productRepository.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
           await _productRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Product>> GetActiveProductAsync()
        {
           return await _productRepository.GetActiveProductAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
           return await _productRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Product>> GetLowStockProductAsync()
        {
            return await _productRepository.GetLowStockProductsAsync();
        }

        public async Task<Product?> GetProductByBarCodeAsync(string barCode)
        {
            return await _productRepository.GetByBarCodeAsync(barCode);
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product?> GetProductByLookupCodeAsync(string lookupCode)
        {
            return await _productRepository.GetByLookupCodeAsync(lookupCode);
        }

        public async Task<Product?> GetProductBySKUAsync(string sku)
        {
            return await _productRepository.GetBySKUAsync(sku);
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return Enumerable.Empty<Product>();

            return await _productRepository.SearchProductsAsync(searchTerm);
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            await ValidateProductAsync(product);
            product.DateModified = DateTime.Now;
            await _productRepository.UpdateAsync(product);
            return product;
        }

        public async Task ValidateProductAsync(Product product)
        {

            if (string.IsNullOrEmpty(product.LookupCode))
                throw new ArgumentException("Lookupcode is required");

            if (string.IsNullOrEmpty(product.SKU))
                throw new ArgumentException("SKU is required");

            if (string.IsNullOrEmpty(product.Barcode))
                throw new ArgumentException("Barcode is required");
            
            
            
            //lookupcode
            var lookupCodeExists = await _productRepository
                .LookupCodeExistsAsync(
                product.LookupCode,
                product.Id > 0 ? product.Id : null);

            if (lookupCodeExists) throw new InvalidOperationException($"Lookup Code" +
                $"'{product.LookupCode}' already exists.");



            //sku
            var skuExists = await _productRepository
                .SKUExistsAsync(product.SKU , product.Id > 0 ? product.Id  : null);

            if (skuExists) throw new InvalidOperationException($"SKU'{product.SKU}'already exists");



            //barcode
          var barcodeExists = await _productRepository
                 .BarcodeExistsAsync(product.Barcode, product.Id > 0 ? product.Id : null);

       if (barcodeExists) throw new InvalidOperationException($"Barcode '?|{product.Barcode}'already" +
                 $"exist");

            

        }



    }
}
