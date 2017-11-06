using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
		ILogger _logger; 
		public ValuesController(ILogger<ValuesController> logger)
		{
			this._logger = logger;
		}

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
			_logger.LogInformation("LoggingEvents.GetItem", "Getting item {ID}", id);
			try
			{

				if (id == 100)
				{
					int i = id / 0;

				}
			}
			catch(Exception e)
			{
				_logger.LogError(e, e.Message);
				throw; 
			}

			return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
