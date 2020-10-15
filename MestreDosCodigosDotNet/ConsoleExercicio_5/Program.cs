using ConsoleExercicio_5.RegraNegocio;
using ConsoleExercicio_5.Uteis;
using System;

namespace ConsoleExercicio_5
{
    class Program
    {
        private const double NUMERO_INDEFINIDO = -9999.99;
        static void Main(string[] args)
        {
            FormulaBhaskara bhaskara = new FormulaBhaskara();

            var valorA = PegarValorParametro("a");
            var valorB = PegarValorParametro("b");
            var valorC = PegarValorParametro("c");

            Console.WriteLine($"Calculando (a = {valorA}, b = {valorB}, c = {valorC})");            
            
            bhaskara.Calcular(valorA, valorB, valorC);
            
            Console.WriteLine(bhaskara.Resultado);
            Console.ReadKey();            
        }


        private static double PegarValorParametro(string nomeParametro)
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Favor informar o valor do parâmetro [{nomeParametro}]");

                var valor = Console.ReadLine().ToDouble(NUMERO_INDEFINIDO);

                var entradaCorreta = (valor != NUMERO_INDEFINIDO);
                if (entradaCorreta)
                    return valor;

                Console.WriteLine("O número informado é inválido, favor informar um número válido!");
                Console.ReadKey();

            } while (true);

        }
    }
}
