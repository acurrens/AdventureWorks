using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Brokers.Logging;
using WebAPI.Services.Products;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSubcategoriesController : ControllerBase
    {

        private readonly IProductSubcategoryService productSubcategoryService;
        private readonly ILoggingBroker logger;
        public ProductSubcategoriesController(IProductSubcategoryService productSubCategoryService, ILoggingBroker loggingBroker)
        {
            this.productSubcategoryService = productSubCategoryService;
            this.logger = loggingBroker;
        }
        // GET: api/<ProductSubCategoryController>
        [HttpGet]
        public async ValueTask<ActionResult<IEnumerable<ProductSubcategory>>> Get()
        {
            logger.Information("Get() api/productsubcategories");
            try
            {
                var productsSubcategories = await productSubcategoryService.GetAllProductSubCategoriesAsync();
                return Ok(productsSubcategories);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return Problem(ex.Message + ex.StackTrace);
            }

        }

        // GET api/<ProductSubCategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductSubCategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductSubCategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductSubCategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
