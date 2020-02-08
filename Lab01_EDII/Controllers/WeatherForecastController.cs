using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab01_EDII.Models;

namespace Lab01_EDII.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        public void Post([FromBody]Soda ssoda)
        {
            Arbol.Instance.AddSoda(ssoda);
        }

        [HttpGet]
        public Soda Get()
        {
            
        }

        [HttpGet]
        public Arbol Get()
        {

        }
    }
}
