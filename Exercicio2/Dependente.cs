namespace Exercicio2
{
    using System;
    using System.Collections.Generic;

    public  class Dependente
    {
        private static int ID = 0;
        public int IDDependente { get; set; }

        public string Nome { get; set; }

        public int Sexo { get; set; }

        public DateTime DataNasc { get; set; }

        public int Relacao { get; set; }

        public Empregado Empregado { get; set; }

        public Dependente(Empregado emp,string nome, EnumSexo sexo, DateTime dataNasc, EnumRelacao relacao)
        {
            IDDependente = Dependente.ID;
            Dependente.ID++;
            Empregado = emp;
            Nome = nome;
            Sexo = (int)sexo;
            DataNasc = dataNasc;
            Relacao = (int)relacao;
        }
    }
}
