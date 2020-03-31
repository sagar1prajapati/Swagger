using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> HomeGet()
        {
            return new string[] { "value7", "value6" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> HomeGet(int id)
        {
            return "value :" + id;
        }
    }
}