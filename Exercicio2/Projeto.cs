namespace Exercicio2
{
    using System;
    using System.Collections.Generic;

    public  class Projeto
    {
        private static int ID = 0;

        public Projeto(string titulo, Departamento departamento)
        {
            Projeto.ID++;
            IDProj = Projeto.ID;
            Titulo = titulo;
            Departamento = departamento;
        }

        public int IDProj { get; set; }

        public string Titulo { get; set; }

        public int IDDepto { get; set; }

        public Departamento Departamento { get; set; }
    }
}
