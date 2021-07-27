using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Brokers.Logging;
using WebAPI.Brokers.Storage;

namespace WebAPI.Services.Products
{
    public class ProductSubcategoryService : IProductSubcategoryService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public ProductSubcategoryService(IStorageBroker storage, ILoggingBroker logging)
        {
            this.storageBroker = storage;
            this.loggingBroker = logging;
        }
        public ValueTask<Product> AddProductSubcategoryAsync(ProductSubcategory productSubcategory)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IEnumerable<ProductSubcategory>> GetAllProductSubCategoriesAsync()
        {

            loggingBroker.Information("GetAllProductsAsync()");
            return await storageBroker.SelectAllProductSubcategoriesAsync();
        }

        public ValueTask<Product> GetProductSubcategoryByIdAsync(int productSubcategoryId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> ModifyProductSubcategoryAsync(ProductSubcategory productSubcategory)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> RemoveProductSubcategoryAsync(int productSubcategoryId)
        {
            throw new NotImplementedException();
        }
    }
}
