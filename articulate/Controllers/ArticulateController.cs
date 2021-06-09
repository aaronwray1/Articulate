using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace articulate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticulateController : ControllerBase
    {
        // private IConfiguration Configuration;
        private readonly ILogger<ArticulateController> _logger;

        public ArticulateController(ILogger<ArticulateController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // string hostname = this.Request.Host.Value.Split(":")[0];
            string categoriesService = $"http://categories:81/categories";
            var category = await new HttpClient().GetStringAsync(categoriesService);

            string numbersService = $"http://numbers:82/numbers";
            var number = await new HttpClient().GetStringAsync(numbersService);
            return Ok(getArticulateFromCSV(category, Int32.Parse(number)));

        }

        private string getArticulateFromCSV(string category, int index)
        {

            using (var reader = new StreamReader("articulate.csv"))
            {

                List<string[]> dataset = new List<string[]>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    dataset.Add(values);
                }
                return dataset[index][categoryToInt(category)];
            }
        }

        private int categoryToInt(string category)
        {
            var catNum = 0;
            switch (category)
            {
                case "Person":
                    catNum = 0;
                    break;
                case "Nature":
                    catNum = 1;
                    break;
                case "Object":
                    catNum = 2;
                    break;
                case "Action":
                    catNum = 3;
                    break;
                case "World":
                    catNum = 4;
                    break;
                case "Random":
                    catNum = 5;
                    break;
            }
            return catNum;
        }

    }
}
