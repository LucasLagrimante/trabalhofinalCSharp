using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Empresa
    {
        public List<Departamento> Departamentos { get; set; }
        public List<Empregado> Empregados { get; set; }
        public List<Dependente> Dependentes { get; set; }
        public List<Projeto> Projetos { get; set; }
        public List<TrabalhaEm> Trabalhos { get; set; }

        public Empresa()
        {
            Departamentos = new List<Departamento>();
            Empregados = new List<Empregado>();
            Dependentes = new List<Dependente>();
            Projetos = new List<Projeto>();
            Trabalhos = new List<TrabalhaEm>();
        }
    }
}
