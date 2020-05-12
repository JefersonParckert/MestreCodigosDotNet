using ConsoleExercicio_2.RegraNegocio;
using ConsoleExercicio_2.Util;
using System;
using System.Collections.Generic;

namespace ConsoleExercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios.Add(new Funcionario("Aldemar Vigário", 1500.45));
            funcionarios.Add(new Funcionario("Pedro Pedreira", 6352.15));
            funcionarios.Add(new Funcionario("Rolando Lero", 5000.40));
            funcionarios.Add(new Funcionario("Galeão Cumbica", 7000.0));
            funcionarios.Add(new Funcionario("Dona Capitu", 6500.85));
            funcionarios.Add(new Funcionario("Baltazar da Rocha", 2900.0));

            var funcoesLista = new FuncoesLista<Funcionario>(funcionarios);

            Console.WriteLine($"Funcionário com MENOR salário (FOR).: {funcoesLista.PegarMenorItemFor()}");
            Console.WriteLine($"Funcionário com MAIOR salário (FOR).: {funcoesLista.PegarMaiorItemFor()}");
            Console.WriteLine($"Funcionário com MENOR salário (WHILE).: {funcoesLista.PegarMenorItemWhile()}");
            Console.WriteLine($"Funcionário com MAIOR salário (WHILE).: {funcoesLista.PegarMaiorItemWhile()}");
            Console.ReadKey();

        }
    }
}
