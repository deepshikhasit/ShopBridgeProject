using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopBridge.Model;
using ShopBridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        //Add Product  
        [HttpPost("AddProduct")]
        public async Task<WebApiResponse<int>> AddProduct(Product product)
        {
            try
            {
                WebApiResponse<int> response = new WebApiResponse<int>();
                if (product != null)
                {
                    var result = await _productService.InsertProduct(product);
                    response.Status = result == 1 ? true : false;
                    response.Message = "Product created successfully!";

                    return response;
                }
                else
                    return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Update Product
        [HttpPut("UpdateProduct")]
        public async Task<WebApiResponse<bool>> UpdateProduct(Product product)
        {
            try
            {
                WebApiResponse<bool> response = new WebApiResponse<bool>();
                if (product != null)
                {
                    var result = await _productService.UpdateProduct(product);
                    response.Status = result;
                    response.Message = "Product updated successfully!";
                    return response;
                }
                else
                    return response;


            }
            catch (Exception)
            {
                throw;
            }
        }
        //Delete Product  
        [HttpDelete("DeleteProduct")]
        public async Task<WebApiResponse<bool>> DeleteProduct(int productId)
        {
            try
            {
                WebApiResponse<bool> response = new WebApiResponse<bool>();
                var product = await _productService.GetProductById(productId);
                if (product != null)
                {
                    var result = await _productService.DeleteProduct(product);
                    response.Status = result;
                    response.Message = "Product deleted successfully!";
                    response.Data = result;
                    return response;
                }
                else
                {
                    response.Status = false;
                    response.Message = "Product not found!";
                    return response;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //GET All Product  
        [HttpGet("GetAllProduct")]
        public async Task<WebApiResponse<IEnumerable<Product>>> GetAllProduct()
        {
            try
            {
                WebApiResponse<IEnumerable<Product>> response = new WebApiResponse<IEnumerable<Product>>();
                var result = await _productService.GetAllProducts();

                response.Status = true;
                response.Message = "Success!";
                response.Data = result;
                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
