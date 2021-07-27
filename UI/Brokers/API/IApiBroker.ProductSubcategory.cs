using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Brokers.API
{
    public partial interface IApiBroker
    {
        ValueTask<IEnumerable<ProductSubcategory>> GetAllProductSubcategoriesAsync();
    }
}
