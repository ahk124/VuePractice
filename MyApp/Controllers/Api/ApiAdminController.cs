using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiAdminController : ControllerBase
    {
            
        [HttpPost]
        public IActionResult Post([FromBody] MyViewModel model)
        {
            Thread.Sleep(3000);

            return Ok(new { message = $"{model.FirstName}       {model.LastName}" });
        }


    }
}