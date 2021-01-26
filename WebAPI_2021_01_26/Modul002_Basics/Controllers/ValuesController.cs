using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modul002_Basics.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // https://localhost:12345/api/Values
        // GET: api/<ValuesController>
        [HttpGet] //<- HTTP Verb
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        //https://localhost:12345/api/Values/123
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        //https://localhost:12345/api/Values
        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //https://localhost:12345/api/Values
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
