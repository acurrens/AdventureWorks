using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;

namespace UI.Brokers.API
{
    public partial interface IApiBroker
    {
        ValueTask<Product> GetProductsAsync(Product product);
    }
}
