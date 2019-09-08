﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Aluno
    {
        //mapeando a entidade Aluno da camada Negocios
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public DateTime DataIncricao {get; set; }
        public string Sexo { get; set; }
    }
}
