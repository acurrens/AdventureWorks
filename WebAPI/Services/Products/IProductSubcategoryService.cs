using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Services.Products
{
    public interface IProductSubcategoryService
    {
        ValueTask<IEnumerable<ProductSubcategory>> GetAllProductSubCategoriesAsync();
        ValueTask<Product> GetProductSubcategoryByIdAsync(int productSubcategoryId);
        ValueTask<Product> ModifyProductSubcategoryAsync(ProductSubcategory productSubcategory);
        ValueTask<Product> AddProductSubcategoryAsync(ProductSubcategory productSubcategory);
        ValueTask<Product> RemoveProductSubcategoryAsync(int productSubcategoryId);
    }
}
