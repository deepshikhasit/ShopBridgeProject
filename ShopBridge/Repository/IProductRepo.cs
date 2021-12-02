using ShopBridge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Repository
{
    public interface IProductRepo
    {
        Task<Product> GetProductById(int productId);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<int> InsertProduct(Product product);
        Task<bool> DeleteProduct(Product product);
        Task<bool> UpdateProduct(Product product);
    }
}
