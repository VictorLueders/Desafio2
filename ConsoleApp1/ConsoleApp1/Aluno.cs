﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios
{
    internal class Aluno
    {
        public int TempoAtraso { get; set; }

        public Aluno()
        {

        }

        public Aluno(int tempoAtraso)
        {
            this.TempoAtraso = tempoAtraso;
        }
    }
}
