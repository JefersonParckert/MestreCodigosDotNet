using System;
using System.Collections.Generic;

namespace ExercicioPOO_1.ExemploInterface
{
    public class OrdemDecrescente: IOrdenacao
    {
        public void Ordenar(List<string> lista)
        {
            lista.Sort();
            lista.Reverse();

            Console.WriteLine("Ordem Decrescente");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

    }
}