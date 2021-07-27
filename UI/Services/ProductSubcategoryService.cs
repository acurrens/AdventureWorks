using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Brokers.API;
using UI.Brokers.Logging;

namespace UI.Services
{
    public class ProductSubcategoryService : IProductSubcategoryService
    {
        private readonly IApiBroker apiBroker;
        private readonly ILoggingBroker logger;
        public ProductSubcategoryService(IApiBroker api, ILoggingBroker loggingBroker)
        {
            this.apiBroker = api;
            this.logger = loggingBroker;
        }

        public ValueTask<IEnumerable<ProductSubcategory>> GetAllProductSubcategories()
        {
            logger.Information($"GetAllProductSubcategories()");
            return apiBroker.GetAllProductSubcategoriesAsync();
        }
    }
}
