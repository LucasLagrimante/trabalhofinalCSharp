namespace Exercicio2
{
    using System;
    using System.Collections.Generic;

    public class TrabalhaEm
    {
        public int Horas { get; set; }

        public Empregado Empregado { get; set; }

        public Projeto Projeto { get; set; }

        public TrabalhaEm(Empregado empregado, Projeto projeto, int horas)
        {
            Empregado = empregado;
            Projeto = projeto;
            Horas = horas;
        }
    }
}
