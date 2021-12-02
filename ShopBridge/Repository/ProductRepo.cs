using Dapper;
using Microsoft.Extensions.Configuration;
using ShopBridge.Model;
using ShopBridge.Repository.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib;

using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ShopBridge.Repository
{
    public class ProductRepo : IProductRepo
    {
        private readonly IConnectionFactory _connectionFactory;
        public ProductRepo(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<bool> DeleteProduct(Product product)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(_connectionFactory.GetConnectionString()))
                {
                  return await conn.DeleteAsync(product);
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(_connectionFactory.GetConnectionString()))
                {
                    return await conn.GetAllAsync<Product>();
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<Product> GetProductById(int productId)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(_connectionFactory.GetConnectionString()))
                {
                    return await conn.GetAsync<Product>(productId);
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<int> InsertProduct(Product product)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(_connectionFactory.GetConnectionString()))
                {
                   return await conn.InsertAsync(product);
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                using (IDbConnection conn = new SqlConnection(_connectionFactory.GetConnectionString()))
                {
                    product.UpdatedDate = DateTime.Now;
                   return await conn.UpdateAsync(product);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
