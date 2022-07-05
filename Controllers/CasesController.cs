using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CasesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CasesController> _logger;

        public CasesController(ILogger<CasesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable <CasesController> Get(string CountryExp)
        {

            var query = from c in DB.Case
                        where c.Country.exp = CountryExp
                        select c;



        }
    }
}
