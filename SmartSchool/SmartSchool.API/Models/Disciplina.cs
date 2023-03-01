using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina()
        {

        }

        public Disciplina(int id, string nome, string professorId)
        {
            Id = id;
            Nome = nome;
            ProfessorId = professorId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string ProfessorId{ get; set; }
        public Professor professor { get; set; }

        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }

    }
}