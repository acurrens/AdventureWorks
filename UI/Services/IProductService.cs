using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Services
{
    public interface IProductService
    {
        ValueTask<IEnumerable<Product>> GetAllProducts();

    }
}
