using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //private readonly IConfiguration configuration;
        //public HomeController(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}
        // GET: api/<HomeController>
        [HttpGet]
        public string Get()
        {
            //SqlConnection sqlConnection = new SqlConnection(configuration.GetConnectionString("default"));
            //sqlConnection.Open();
            //string query = "select * from Production.Product";
            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //string result = "";
            //while (sqlDataReader.Read())
            //{
            //    result += sqlDataReader[0].ToString() + "|";
            //    result += sqlDataReader[1].ToString() + "|";
            //    result += sqlDataReader[2].ToString() + "|";
            //    result += sqlDataReader[3].ToString();
            //}
            //sqlConnection.Close();
            return "Sorry Mario, but the princess is in another castle!";
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
