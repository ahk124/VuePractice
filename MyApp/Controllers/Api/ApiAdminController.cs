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
            [HttpGet]
        public  IActionResult Get()
        {
            return Ok("get");
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
             return Ok($"name is : {name.ToString()}");
        }

        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int Id)
        {
            return Ok($"id is : {Id.ToString()}");
        } 

        [HttpPost]
        public IActionResult Post([FromBody] MyViewModel model)
        {
            Thread.Sleep(3000);

            return Ok(new { message = $"{model.FirstName}       {model.LastName}" });
        }


    }
}