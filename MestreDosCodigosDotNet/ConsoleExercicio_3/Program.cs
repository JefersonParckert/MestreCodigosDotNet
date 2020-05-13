using System;

namespace ConsoleExercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibindo todos os números multiplos de 3 entre 1 e 100");
            int numero = 1;
            while (numero <= 100) 
            {
                if ((numero % 3) == 0)
                    Console.WriteLine($"O número {numero} é multiplo de 3");

                numero++;
            }

            Console.ReadKey();

        }
    }
}
