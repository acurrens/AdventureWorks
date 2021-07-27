using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UI.Brokers.Logging;
using UI.Services;

namespace UI.ViewModels
{

    public class ProductListView : IProductListView
    {
        private readonly IProductService productService;
        private readonly IProductSubcategoryService subcategoryService;
        private readonly ILoggingBroker logger;

        public ProductListView(IProductService productService, IProductSubcategoryService productSubcategoryService, ILoggingBroker loggingBroker)
        {
            this.subcategoryService = productSubcategoryService;
            this.productService = productService;
            this.logger = loggingBroker;
        }

        public int ProductID { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Product Number")]
        public string ProductNumber { get; set; }
		public bool MakeFlag { get; set; }
		public string ProductCategory { get; set; }
        [Display(Name = "Subcategory")]
		public string ProductSubcategory { get; set; }

        public async Task<List<ProductListView>> GetProductListAsync()
        {
            var products = await productService.GetAllProducts();
            var productSubcategories = await subcategoryService.GetAllProductSubcategories();
            return MapToProductListView(products, productSubcategories);
        }

        private List<ProductListView> MapToProductListView(IEnumerable<Product> products, IEnumerable<ProductSubcategory> subcategories)
        {
            var results = (from p in products
                           join subcat in subcategories on p.ProductSubcategoryID equals subcat.ProductSubcategoryID into lj
                           from subsubcat in lj.DefaultIfEmpty()
                           select new ProductListView(productService, subcategoryService, logger)
                           {
                               ProductID = p.ProductID,
                               Name = p.Name,
                               ProductNumber = p.ProductNumber,
                               MakeFlag = p.MakeFlag,
                               ProductSubcategory = subsubcat?.Name ?? String.Empty
                           }).ToList();
            return results;
        }
    }
}
