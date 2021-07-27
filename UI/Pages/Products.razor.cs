using Domain.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Brokers.Logging;
using UI.Models;
using UI.Services;
using UI.ViewModels;

namespace UI.Pages
{
    public partial class Products : ComponentBase
    {
        [Inject] IProductListView productListViewService { get; set; }
        [Inject] ILoggingBroker logger { get; set; }
        List<ProductListView> products = new List<ProductListView>();
        [Parameter] public ComponentState State { get; set; }
        protected async override Task OnInitializedAsync()
        {
            State = ComponentState.Loading;
            //products = (await productService.GetAllProducts()).ToList();
            products = await productListViewService.GetProductListAsync();
            logger.Information($"productCount: {products.Count}");
            State = ComponentState.Content;

        }
    }
}
