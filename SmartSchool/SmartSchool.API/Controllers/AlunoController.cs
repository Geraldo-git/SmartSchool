using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public AlunoController()
        {

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Alunos: Lucas, Gabriel, Luna, Mara");
        }
    }
}
