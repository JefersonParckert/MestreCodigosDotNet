using System;
using System.Collections.Generic;

namespace ExercicioPOO_1.ExemploInterface
{
    public class OrdemCrescente: IOrdenacao
    {
        public void Ordenar(List<string> lista)
        {
            lista.Sort();

            Console.WriteLine("Ordem Crescente");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}