using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using RepoDb;
using System.Collections.Generic;
using BlazorRepoMaria.Shared;

namespace BlazorRepoMaria.Server.Repos
{
    public interface IMariaRepo {
        IEnumerable<Product> GetProducts();
    }

    public class MariaRepo : DbRepository<MySqlConnector.MySqlConnection>, IMariaRepo
    {

        public MariaRepo(IConfiguration config) : base(config.GetConnectionString("MariaConnection"))
        {
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = QueryAll<Product>();
            return products;
        }

    }
}
