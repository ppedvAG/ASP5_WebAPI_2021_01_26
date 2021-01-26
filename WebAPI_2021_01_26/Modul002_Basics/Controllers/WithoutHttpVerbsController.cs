using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul002_Basics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WithoutHttpVerbsController : ControllerBase
    {
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                             nameof(DefaultApiConventions.Get))]
        public string GetTeilnehmer() 
        {
            return "Hallo liebe Teilnehmer!";
        }
    }
}
