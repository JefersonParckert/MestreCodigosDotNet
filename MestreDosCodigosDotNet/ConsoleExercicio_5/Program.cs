using ConsoleExercicio_5.RegraNegocio;
using System;

namespace ConsoleExercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            FormulaBhaskara bhaskara = new FormulaBhaskara();

            //DELTA maior que ZERO
            Console.WriteLine("Calculando (a = 1, b = -1, c = -6)");
            bhaskara.Calcular(1, -1, -6);
            Console.WriteLine(bhaskara.Resultado);
            Console.WriteLine();

            //DELTA igual que ZERO
            Console.WriteLine("Calculando (a = 1, b = -8, c = 16)");
            bhaskara.Calcular(1, -8, 16);
            Console.WriteLine(bhaskara.Resultado);
            Console.WriteLine();

            //DELTA menor que ZERO
            Console.WriteLine("Calculando (a = 1, b = -8, c = 16)");
            bhaskara.Calcular(-1, 2, -2);
            Console.WriteLine(bhaskara.Resultado);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
