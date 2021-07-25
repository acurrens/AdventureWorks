using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.Products
{
    public interface IProductService
    {
        ValueTask<IEnumerable<Product>> GetAllProductsAsync();
        ValueTask<Product> GetProductByIdAsync(int productId);
        ValueTask<Product> ModifyProductAsync(Product product);
        ValueTask<Product> AddProductAsync(Product product);
        ValueTask<Product> RemoveProductAsync(int productId);
    }
}
