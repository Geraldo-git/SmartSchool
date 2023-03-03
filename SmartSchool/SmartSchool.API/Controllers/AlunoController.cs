using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;
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

        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id =1,
                Nome = "Marcos",
                Sobrenome = "Almeida",
                Telefone = "999999"
            },
            new Aluno()
            {
                Id =2,
                Nome = "Marcia",
                Sobrenome = "Santos",
                Telefone = "999998"
            },
            new Aluno()
            {
                Id =3,
                Nome = "Francismeire",
                Sobrenome = "Vilela",
                Telefone = "999997"
            }
        };
        public AlunoController()
        {

        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("Aluno não encontrado");
            return Ok(aluno);
        }
    }
}
