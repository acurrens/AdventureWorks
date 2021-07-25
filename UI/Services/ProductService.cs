using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Brokers.API;
using UI.Brokers.Logging;

namespace UI.Services
{
    public class ProductService : IProductService
    {
        private readonly IApiBroker apiBroker;
        private readonly ILoggingBroker logger;
        public ProductService(IApiBroker api,ILoggingBroker loggingBroker)
        {
            this.apiBroker = api;
            this.logger = loggingBroker;
        }
        public ValueTask<IEnumerable<Product>> GetAllProducts()
        {
            logger.Information($"GetAllProducts()");
            return apiBroker.GetAllProductsAsync();
            
        }
    }
}
