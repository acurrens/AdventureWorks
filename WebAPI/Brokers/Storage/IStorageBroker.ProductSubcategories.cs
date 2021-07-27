using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Brokers.Storage
{
    public partial interface IStorageBroker
    {
        ValueTask<ProductSubcategory> InsertProductSubcategoryAsync(ProductSubcategory productSubcategory);
        ValueTask<IEnumerable<ProductSubcategory>> SelectAllProductSubcategoriesAsync();
        ValueTask<ProductSubcategory> SelectProductSubcategoryByIdAsync(int productSubcategoryId);
        ValueTask<ProductSubcategory> UpdateProductSubcategoryAsync(ProductSubcategory productSubcategory);
        ValueTask<ProductSubcategory> DeleteProductSubcategoryAsync(ProductSubcategory productSubcategory);
    }
}
