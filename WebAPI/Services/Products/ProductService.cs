using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Brokers.Logging;
using WebAPI.Brokers.Storage;

namespace WebAPI.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly IStorageBroker storageBroker;
        //private readonly ILoggingBroker loggingBroker;
        
        public ProductService(IStorageBroker storage)//, ILoggingBroker logging)
        {
            this.storageBroker = storage;
            //this.loggingBroker = logging;
        }

        public ValueTask<Product> AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await storageBroker.SelectAllProductsAsync();
        }

        public ValueTask<Product> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> ModifyProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Product> RemoveProductAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
