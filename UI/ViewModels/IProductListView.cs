using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public interface IProductListView
    {
        Task<List<ProductListView>> GetProductListAsync();
    }
}
