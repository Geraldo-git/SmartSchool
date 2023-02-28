using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina(Parameters)
        { }
        
        public Disciplina(int id, string nome, int professorId) 
        {
            this.Id = id;
            this.Nome = nome;
            this.professorId = professorId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Professor Id { get; set; }
        public Professor professor {get; set;}
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas{ get; set; }

    }
}