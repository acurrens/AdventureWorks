using Domain.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Brokers.Logging;
using UI.Services;

namespace UI.Pages
{
    public partial class Products : ComponentBase
    {
        [Inject] IProductService productService { get; set; }
        [Inject] ILoggingBroker logger { get; set; }
        List<Product> products = new List<Product>();
        protected async override Task OnInitializedAsync()
        {
            
            products = (await productService.GetAllProducts()).ToList();
            logger.Information($"productCount: {products.Count}");
        }
    }
}
