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
            var data=new {Message="Hello angal"};
            return Ok(data);
        }

        [HttpGet("GetByName/{name}")]
        public IActionResult GetByName(string name)
        {
            var data=new {Message=$"name is : {name.ToString()}"};
             return Ok(data);
        }

        [HttpGet("GetById/{Id}")]
        public IActionResult GetById(int Id)
        {
            var data=new {Message=$"id is : {Id.ToString()}"};
            return Ok(data);
        } 

        [HttpPost("PostMyData")]
        public IActionResult PostMyData([FromBody] MyViewModel model)
        {
            Thread.Sleep(3000);

            return Ok(new { Message = $"{model.FirstName}       {model.LastName}" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] MyViewModel model)
        {
            Thread.Sleep(3000);

            return Ok(new { message = $"{model.FirstName}       {model.LastName}" });
        }


    }
}