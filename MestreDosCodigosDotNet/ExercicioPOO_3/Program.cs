using ExercicioPOO_3.Dominio;
using System;

namespace ExercicioPOO_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente1 = new ContaCorrente(1, 12.2, 0.35);
            contaCorrente1.Depositar(50);
            contaCorrente1.Sacar(60);
            contaCorrente1.MostrarDados();

            Console.ReadKey();
            Console.Clear();

            var contaCorrente2 = new ContaCorrente(2, 25.0, 0.35);
            contaCorrente2.Sacar(60);
            contaCorrente2.Depositar(50);            
            contaCorrente2.MostrarDados();

            Console.ReadKey();
            Console.Clear();

            var contaEspecial1 = new ContaEspecial(3, 10.0, 1000.0);
            contaEspecial1.Sacar(900.0);
            contaEspecial1.Depositar(350.0);
            contaEspecial1.MostrarDados();

            Console.ReadKey();
            Console.Clear();

            var contaEspecial2 = new ContaEspecial(4, 10.0, 500.0);
            contaEspecial2.Sacar(900.0);
            contaEspecial2.Depositar(150.0);
            contaEspecial2.Sacar(660.0);
            contaEspecial2.MostrarDados();

            Console.ReadKey();            
        }
    }
}
