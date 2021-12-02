using ShopBridge.Model;
using ShopBridge.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public async Task<bool> DeleteProduct(Product product)
        {
           return await _productRepo.DeleteProduct(product);
        }

        public async  Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepo.GetAllProducts();
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _productRepo.GetProductById(productId);
        }

        public async Task<int> InsertProduct(Product product)
        {
           return await _productRepo.InsertProduct(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
           return await _productRepo.UpdateProduct(product);
        }
    }
}
