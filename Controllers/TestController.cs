using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aj.microService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Object GetTestContent()
        {
            return new
            {
                api = "base",
                dates = Enumerable.Range(1, 5).Select(index => DateTime.Now.AddDays(index)).ToArray(),
            };
        }
    }
}
