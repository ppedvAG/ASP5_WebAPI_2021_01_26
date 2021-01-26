using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul002_Basics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]                                    //ApiController ist <= 4.8 Version
    public class StatusCodeController : ControllerBase //ControllerBase ist ab ASP.NET Core 
    {
        [HttpGet]

        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status204NoContent)]
        public IActionResult Index()
        {
            
            return NotFound("ABC nicht gefunden");  // Status204NoContent
        }

        [HttpPost]
        public IActionResult PostSave(string id)
        {
            //suche nach Id
            //Wenn nicht gefunden return StatusCode(404);

            //Wenn gefunden OK
            return Ok("Test"); // 200 
        }

        [HttpPut]
        public IActionResult PutSave(string test)
        {
            return StatusCode(123); // Definieren von Http-Status Code
        }
    }
}
