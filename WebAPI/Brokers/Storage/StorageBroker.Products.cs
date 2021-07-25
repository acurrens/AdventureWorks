using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Brokers.Storage
{
    public partial class StorageBroker
    {
        public async ValueTask<IEnumerable<Product>> SelectAllProductsAsync()
        {
            using var connection = new SqlConnection(connectionString: configuration.GetConnectionString("default"));
            string query = "SELECT * FROM Production.Product";
            var products = await connection.QueryAsync<Product>(query);
            logger.Information($"SelectAllProductsAsync(): {query} | {products.Count()}");
            return products;
        }
        public async ValueTask<Product> SelectProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
        
        public async ValueTask<Product> InsertProductAsync(Product product)
        {

            throw new NotImplementedException();
        }
        
        public async ValueTask<Product> DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }


    }
}
