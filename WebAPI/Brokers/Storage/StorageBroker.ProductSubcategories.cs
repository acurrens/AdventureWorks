using Dapper;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Brokers.Storage
{
    public partial class StorageBroker : IStorageBroker
    {
        public async ValueTask<ProductSubcategory> InsertProductSubcategoryAsync(ProductSubcategory productSubcategory)
        {
            throw new NotImplementedException();
        }
        public async ValueTask<IEnumerable<ProductSubcategory>> SelectAllProductSubcategoriesAsync()
        {
            using var connection = new SqlConnection(connectionString: configuration.GetConnectionString("default"));
            string query = "SELECT * FROM Production.ProductSubcategory";
            var productsSubcategories = await connection.QueryAsync<ProductSubcategory>(query);
            logger.Information($"SelectAllProductSubcategoriesAsync(): {query} | {productsSubcategories.Count()}");
            return productsSubcategories;
        }
        public async ValueTask<ProductSubcategory> SelectProductSubcategoryByIdAsync(int productSubcategoryId)
        {
            throw new NotImplementedException();
        }
        public async ValueTask<ProductSubcategory> UpdateProductSubcategoryAsync(ProductSubcategory productSubcategory)
        {
            throw new NotImplementedException();
        }
        public async ValueTask<ProductSubcategory> DeleteProductSubcategoryAsync(ProductSubcategory productSubcategory)
        {
            throw new NotImplementedException();
        }
    }
}
