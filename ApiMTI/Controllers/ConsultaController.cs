using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiMTI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ConsultaController : ControllerBase
    {
        private readonly ILogger<ConsultaController> _logger;

        public ConsultaController(ILogger<ConsultaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        [HttpPost]
        public IEnumerable<string> Post()
        {
            return new string[] { "Hola Mundo Post" };
        }
    }
}
