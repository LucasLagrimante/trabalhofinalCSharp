using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static Empresa GerarDados()
        {
            //Criação de departamentos
            
            Departamento dep1 = new Departamento("Pesquisa");
            Departamento dep2 = new Departamento("Administração");
            Departamento dep3 = new Departamento("Direção");
            
            //Criação de empregados e colocando gerentes nos departamentos
            Empregado emp1 = new Empregado("Joao da Silva", new DateTime(1955, 01, 09), "Rua dos Camelos, 23", EnumSexo.Masculino, 30000, dep2);
            Empregado emp2 = new Empregado("Horacio Bagual", new DateTime(1953, 10, 10), "Av. dos Tapejaras, 90", EnumSexo.Masculino, 40000, dep1);
            Empregado emp3 = new Empregado("Ana Bacana", new DateTime(1980, 06, 20), "Av. Atacama, 10 apto 22", EnumSexo.Feminino, 25000, dep3);
            Empregado emp4 = new Empregado("Antonio Pestana", new DateTime(1990, 04, 13), "Rod. Imigrantes, 1940", EnumSexo.Masculino, 45000, dep2);
            Empregado emp5 = new Empregado("Maria Antonia Real", new DateTime(1982, 11, 14), "Rua Petropolis, 13", EnumSexo.Feminino, 38000, dep1);
            Empregado emp6 = new Empregado("Ada Maria Lovelace", new DateTime(1965, 10, 15), "Rua dos Ingleses, 1020", EnumSexo.Feminino, 25000, dep1);
            Empregado emp7 = new Empregado("Joaquina Pasqualini", new DateTime(1968, 08, 17), "Rua dos Ingleses, 1010", EnumSexo.Feminino, 25000, dep2);
            Empregado emp8 = new Empregado("Luiz Gustavo Silva", new DateTime(1982, 09, 13), "Rua Silva Jardim, 87", EnumSexo.Masculino, 50000, dep3);
            Empregado emp9 = new Empregado("Amanda Lima Costa", new DateTime(1979, 03, 01), "Av. Rio Branco, 1290, Ap. 207", EnumSexo.Feminino, 31000, dep2);
            
            //Criação de Projetos
            Projeto proj1 = new Projeto("Transmogrifador", dep1);
            Projeto proj2 = new Projeto("Cama Hiperbarica", dep1);
            Projeto proj3 = new Projeto("Emissor de Raios Z", dep1);
            Projeto proj4 = new Projeto("Gestao dos 80/20", dep2);
            Projeto proj5 = new Projeto("Business Inteligence", dep3);
            Projeto proj6 = new Projeto("Bonus para Inventores", dep2);

            //Criação trabalhos em projetos
            TrabalhaEm trab1 = new TrabalhaEm(emp1, proj1, 10);
            TrabalhaEm trab2 = new TrabalhaEm(emp5, proj3, 40);
            TrabalhaEm trab3 = new TrabalhaEm(emp6, proj1, 20);
            TrabalhaEm trab4 = new TrabalhaEm(emp6, proj2, 20);
            TrabalhaEm trab5 = new TrabalhaEm(emp2, proj2, 10);
            TrabalhaEm trab6 = new TrabalhaEm(emp2, proj3, 10);
            TrabalhaEm trab7 = new TrabalhaEm(emp4, proj4, 15);
            TrabalhaEm trab8 = new TrabalhaEm(emp4, proj5, 12);
            TrabalhaEm trab9 = new TrabalhaEm(emp8, proj6, 7);
            TrabalhaEm trab10 = new TrabalhaEm(emp8, proj4, 20);
            TrabalhaEm trab11 = new TrabalhaEm(emp9, proj4, 30);
            TrabalhaEm trab12 = new TrabalhaEm(emp3, proj3, 20);
            TrabalhaEm trab13 = new TrabalhaEm(emp3, proj5, 10);
            TrabalhaEm trab14 = new TrabalhaEm(emp1, proj2, 15);

            //Criação de Dependentes
            Dependente depend1 = new Dependente(emp2, "Joana Bagual", EnumSexo.Feminino, new DateTime(1986, 05, 05), EnumRelacao.Filho);
            Dependente depend2 = new Dependente(emp2, "Pedro Bagual", EnumSexo.Masculino, new DateTime(1983, 10, 25), EnumRelacao.Filho);
            Dependente depend3 = new Dependente(emp2, "Alice Bagual", EnumSexo.Feminino, new DateTime(1956, 05, 03), EnumRelacao.Conjuge);
            Dependente depend4 = new Dependente(emp3, "Maximo Bacana", EnumSexo.Masculino, new DateTime(1942, 02, 28), EnumRelacao.Pais);
            Dependente depend5 = new Dependente(emp1, "Jagunco da Silva", EnumSexo.Masculino, new DateTime(1978, 01, 01), EnumRelacao.Filho);
            Dependente depend6 = new Dependente(emp1, "Jaqueline da Silva", EnumSexo.Feminino, new DateTime(1978, 12, 31), EnumRelacao.Filho);
            Dependente depend7 = new Dependente(emp1, "Joana da Silva", EnumSexo.Feminino, new DateTime(1957, 05, 05), EnumRelacao.Conjuge);

            Empresa empresa = new Empresa();
                      
            empresa.Departamentos.Add(dep1);
            empresa.Departamentos.Add(dep2);
            empresa.Departamentos.Add(dep3);

            empresa.Empregados.Add(emp1);
            empresa.Empregados.Add(emp2);
            empresa.Empregados.Add(emp3);
            empresa.Empregados.Add(emp4);
            empresa.Empregados.Add(emp5);
            empresa.Empregados.Add(emp6);
            empresa.Empregados.Add(emp7);
            empresa.Empregados.Add(emp8);
            empresa.Empregados.Add(emp9);

            //Definindo Gerentes
            //dep2.Gerente = emp1;
            dep1.Gerente = emp2;
            dep3.Gerente = emp8;
                
            empresa.Projetos.Add(proj1);
            empresa.Projetos.Add(proj2);
            empresa.Projetos.Add(proj3);
            empresa.Projetos.Add(proj4);
            empresa.Projetos.Add(proj5);
            empresa.Projetos.Add(proj6);

            empresa.Trabalhos.Add(trab1);
            empresa.Trabalhos.Add(trab2);
            empresa.Trabalhos.Add(trab3);
            empresa.Trabalhos.Add(trab4);
            empresa.Trabalhos.Add(trab5);
            empresa.Trabalhos.Add(trab6);
            empresa.Trabalhos.Add(trab7);
            empresa.Trabalhos.Add(trab8);
            empresa.Trabalhos.Add(trab9);
            empresa.Trabalhos.Add(trab10);
            empresa.Trabalhos.Add(trab11);
            empresa.Trabalhos.Add(trab12);
            empresa.Trabalhos.Add(trab13);
            empresa.Trabalhos.Add(trab14);

            empresa.Dependentes.Add(depend1);
            empresa.Dependentes.Add(depend2);
            empresa.Dependentes.Add(depend3);
            empresa.Dependentes.Add(depend4);
            empresa.Dependentes.Add(depend5);
            empresa.Dependentes.Add(depend6);
            empresa.Dependentes.Add(depend7);

            return empresa;
        }
        

        static void Main(string[] args)
        {
            Empresa empresa = GerarDados();

            //a.	Alterar o salário do empregado de código 3 para 28000
            Console.WriteLine("Letra A:");
            var exA = from empregado in empresa.Empregados
                              where empregado.IDEmp == 3
                              select empregado;

            foreach (var x in exA)
            {
                Console.WriteLine(x.Salario);
                x.Salario = 28000;
                Console.WriteLine(x.Salario);
            }

            //b.	Obter nomes de empregados com salario > 30000
            Console.WriteLine("\n\nLetra B:");
            var exB = from empregado in empresa.Empregados
                              orderby empregado.Salario
                              where empregado.Salario > 30000
                              select empregado;

            foreach (var x in exB)
            {
                Console.WriteLine(x.Nome + " - " + x.Salario);
            }

            //c.Obter nomes de empregados que trabalham no projeto 'Transmogrifador'
            Console.WriteLine("\n\nLetra C:");
            var exC = from trabalha in empresa.Trabalhos
                      where trabalha.Projeto.Titulo == "Transmogrifador"
                      select trabalha.Empregado.Nome;

            foreach (var x in exC)
            {
                Console.WriteLine(x);
            }


            //d.	Obter nomes e endereços de todos os empregados que trabalham no departamento de 'Pesquisa'.
            Console.WriteLine("\n\nLetra D:");
            var exD = from trabalhador in empresa.Empregados
                      where trabalhador.Departamento.Nome == "Pesquisa"
                      select new { Nome = trabalhador.Nome, Endereco = trabalhador.Endereco };

            foreach (var x in exD)
            {
                Console.WriteLine(x.Nome +" - "+ x.Endereco);
            }

            //e.	Obter nomes de empregados que começam com a letra 'A'
            Console.WriteLine("\n\nLetra E:");
            var exE = from trabalhador in empresa.Empregados
                      where trabalhador.Nome.StartsWith("A")
                      select trabalhador.Nome;

            foreach (var x in exE)
            {
                Console.WriteLine(x);
            }

            //f.Obter os nomes e datas de nascimento dos empregados que fazem aniversário no mês de outubro.
            Console.WriteLine("\n\nLetra F:");
            var exF = from trabalhador in empresa.Empregados
                      where trabalhador.DataNasc.Month == 10
                      select new { Nome = trabalhador.Nome, DataNasc = trabalhador.DataNasc };

            foreach (var x in exF)
            {
                Console.WriteLine(x.Nome + " - " + x.DataNasc);
            }

            //g.	Obter os nomes dos empregados nascidos entre as datas 1950-01-01 e 1970-01-01.
            Console.WriteLine("\n\nLetra G:");
            DateTime start = new DateTime(1950, 01, 01);
            DateTime end = new DateTime(1970, 01, 01);

            var exG = from trabalhador in empresa.Empregados
                      where trabalhador.DataNasc >= start && trabalhador.DataNasc <= end
                      select trabalhador;

            foreach (var x in exG)
            {
                Console.WriteLine(x.Nome + " - " + x.DataNasc);
            }

            //h.	Listar os títulos de projetos em ordem alfabética.
            Console.WriteLine("\n\nLetra H:");

            var exH = from projeto in empresa.Projetos
                      orderby projeto.Titulo
                      select projeto;

            foreach (var x in exH)
            {
                Console.WriteLine(x.Titulo);
            }


            //i.	Listar nomes e horas trabalhadas por empregados no projeto de código 3, em ordem decrescente de horas trabalhadas.
            Console.WriteLine("\n\nLetra I:");
            var exI = from trabalhaEm in empresa.Trabalhos
                      join projetos in empresa.Projetos on trabalhaEm.Projeto.IDProj equals projetos.IDProj
                      orderby trabalhaEm.Horas descending
                      where projetos.IDProj == 3
                      select new { Nome = trabalhaEm.Empregado.Nome, HorasTrabalhadas = trabalhaEm.Horas, ProjetoId = projetos.IDProj};

            foreach (var x in exI)
            {
                Console.WriteLine(x.HorasTrabalhadas + " - " + x.ProjetoId + " - " + x.Nome);
            }

            //j.	Obter códigos de empregados que trabalham mais de 10 horas em algum projeto. O resultado da consulta não deve ter repetições de códigos de empregados.
            Console.WriteLine("\n\nLetra J:");

            
            //k.Obter a quantidade de empregados pertencentes ao departamento 4.Dica: consulte funções agregadas do SQL.
            Console.WriteLine("\n\nLetra K:");
            
            //l.	Obter, a partir da tabela TrabalhaEm, os números mínimo, máximo e médio de horas trabalhadas por empregados em cada projeto. O resultado deve possuir 4 colunas nomeadas: projeto, minimo, maximo e media.
            Console.WriteLine("\n\nLetra L:");
            
            //m.	Obter os códigos de projetos cuja média de horas trabalhadas seja maior que 20.
            Console.WriteLine("\n\nLetra M:");
            
            //n.Obter os nomes de projetos correspondentes à consulta anterior.
            Console.WriteLine("\n\nLetra N:");
            
        }
    }
}
