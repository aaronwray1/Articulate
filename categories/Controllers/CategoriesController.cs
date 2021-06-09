using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace categories.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private static readonly string[] categories = new[]
        {
            "Object", "Nature", "Random", "Person", "Action", "World"
        };

        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            var rng = new Random();
            return categories[rng.Next(0, 5)];
        }
    }
}
