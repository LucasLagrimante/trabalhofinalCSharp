namespace Exercicio2
{
    using System;
    using System.Collections.Generic;

    public  class Departamento
    {
        private static int ID = 0;
        public int IDDepto { get; set; }

        public string Nome { get; set; }

        public Empregado Gerente { get; set; }

        public Departamento(string nome)
        {
            IDDepto = Departamento.ID;
            Departamento.ID++;
            Nome = nome;
        }
 
        public Departamento(string nome, Empregado gerente) : this(nome)
        {
            Gerente = gerente;
        }

    }
}
