using BlazorRepoMaria.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRepoMaria.Server.Repos;

namespace BlazorRepoMaria.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
      

        private readonly ILogger<ProductController> _logger;
        private readonly IMariaRepo _repo;

        public ProductController(ILogger<ProductController> logger, IMariaRepo repo)
        {
            _logger = logger;
            _repo = repo;

        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = _repo.GetProducts();
            return products;
        }
    }
}
