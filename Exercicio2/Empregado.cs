namespace Exercicio2
{
    using System;
    using System.Collections.Generic;


    public  class Empregado
    {
        private static int ID = 0;
        
        public Empregado(string nome, DateTime dataNasc, string endereco, 
            EnumSexo sexo, Decimal salario, Departamento departamento)
        {
            IDEmp = Empregado.ID;
            Empregado.ID++;
            Nome = nome;
            DataNasc = dataNasc;
            Endereco = endereco;
            Sexo = (int)sexo;
            Salario = salario;
            Departamento = departamento;
        }

        public int IDEmp { get; set; }

        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        public string Endereco { get; set; }

        public int Sexo { get; set; }

        public decimal Salario { get; set; }

        public Departamento Departamento { get; set; }
    }
}
