using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using random;

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

        private readonly IRandomGenerator _random;

        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger, IRandomGenerator random)
        {
            _logger = logger;
            _random = random;
        }

        [HttpGet]
        public String Get()
        {
            return categories[_random.Generate(0, 5)];
        }
    }
}
