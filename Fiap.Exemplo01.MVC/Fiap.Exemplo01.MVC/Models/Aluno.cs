using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo01.MVC.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
    }
}