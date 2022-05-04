using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Aula
    {
        public bool Cancelada { get; set; }

        public int minimoAlunos { get; set; }

        public List<Aluno> Alunos { get; set; }

        public Aula()
        {
            Alunos = new List<Aluno>();
        }

        public Aula(bool cancelada, int minimoAlunos)
        {
            this.Cancelada = cancelada;
            this.minimoAlunos = minimoAlunos;
        }
    }
}
