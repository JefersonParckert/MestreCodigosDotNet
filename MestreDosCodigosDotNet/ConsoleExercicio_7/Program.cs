using ConsoleExercicio_7.Uteis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros = new List<int>();
            for (int i = 1; i < 5; i++)
                listaInteiros.Add(PegarNumeroInteiro(i));

            Console.Clear();
            Console.WriteLine($"Lista de numero digitada [{string.Join(", ", listaInteiros)}]");
            Console.WriteLine($"Resultado da Soma dos numeros pares é.: {PegarSomaNumerosPares(listaInteiros)}");
            Console.ReadKey();
        }

        private static int PegarSomaNumerosPares(List<int> listaInteiros)
        {
            int somatoria = 0;
            foreach (int valor in listaInteiros)
            {
                if (valor.IsPair())
                    somatoria += valor;
            }
            return somatoria;
        }

        private static int PegarNumeroInteiro(int posicao)
        {
            do
            {
                Console.Clear();
                Console.Write($"Informe o numero da posição {posicao} e pressione enter: ");
                
                int valor;
                if (TestarEntradaUsuario(Console.ReadLine(), out valor))
                    return valor;

                Console.Clear();
                Console.WriteLine("O numero digitado é inválido. Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            } while (true);            
        }

        private static bool TestarEntradaUsuario(string valorDigitado, out int resultado)
        {
            return int.TryParse(valorDigitado, out resultado);
        }
    }
}
