using Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositors
{
    public interface IProductRepository
    {
        /// <summary>
        /// List all products
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProducts();

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProduct(string id);

        /// <summary>
        /// List all products by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductByName(string name);

        /// <summary>
        /// List all products by category name
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductByCategory(string categoryName);

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task CreateProduct(Product product);

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<bool> UpdateProduct(Product product);

        /// <summary>
        /// Remove product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteProduct(string id);
    }
}
