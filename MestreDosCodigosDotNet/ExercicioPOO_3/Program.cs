using ExercicioPOO_3.Dominio;
using System;

namespace ExercicioPOO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente1 = new ContaCorrente(1, 12.2m, 0.35m);
            contaCorrente1.Depositar(50m);
            contaCorrente1.Sacar(60m);
            contaCorrente1.MostrarDados();

            Console.ReadKey();
            Console.Clear();

            var contaCorrente2 = new ContaCorrente(2, 25.0m, 0.35m);
            contaCorrente2.Sacar(60m);
            contaCorrente2.Depositar(50m);            
            contaCorrente2.MostrarDados();

            Console.ReadKey();
            Console.Clear();

            var contaEspecial1 = new ContaEspecial(3, 10m, 1000m);
            contaEspecial1.Sacar(900m);
            contaEspecial1.Depositar(350m);
            contaEspecial1.MostrarDados();

            Console.ReadKey();
            Console.Clear();

            var contaEspecial2 = new ContaEspecial(4, 10m, 500m);
            contaEspecial2.Sacar(900m);
            contaEspecial2.Depositar(150m);
            contaEspecial2.Sacar(660m);
            contaEspecial2.MostrarDados();

            Console.ReadKey();            
        }
    }
}
