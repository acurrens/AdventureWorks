using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Brokers.API
{
    public partial class ApiBroker
    {
        private const string productSubcategoryUrl = "api/productsubcategories";
        public async ValueTask<IEnumerable<ProductSubcategory>> GetAllProductSubcategoriesAsync()
        {
            return await this.GetAsync<IEnumerable<ProductSubcategory>>(productSubcategoryUrl);
        }
    }
}
