using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Brokers.API
{
    public partial class ApiBroker
    {
        private const string productsUrl = "api/products";
        public async ValueTask<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await this.GetAsync<IEnumerable<Product>>(productsUrl);
        }
    }
}
