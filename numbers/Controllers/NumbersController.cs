using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using random;

namespace numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        private readonly ILogger<NumbersController> _logger;
        private readonly IRandomGenerator _random;

        public NumbersController(ILogger<NumbersController> logger, IRandomGenerator random)
        {
            _logger = logger;
            _random = random ?? new RandomGenerator();
        }

        [HttpGet]
        public int Get()
        {
            // var rng = new Random();
            return _random.Generate(1, 100);
        }
    }
}
