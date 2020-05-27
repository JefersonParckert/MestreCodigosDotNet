using ConsoleExercicio_9.Uteis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaInteiros = new List<int>() { 25, 45, 78, 112, 26, 10};
            Console.WriteLine($"Lista de inteiros Inicial.: [{listaInteiros.ToListString()}]");
            AguardaUsuario();

            List<int> listaCrescente = (from numero in listaInteiros
                                        orderby numero ascending
                                        select numero).ToList();
            Console.WriteLine($"Lista Inicial.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Lista em ordem crescente(Sintaxe de consulta).:[{listaCrescente.ToListString()}]");
            AguardaUsuario();

            var listaDecrescente = listaInteiros.OrderByDescending(n => n).ToList();
            Console.WriteLine($"Lista Inicial.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Lista em ordem decrescente(Sintaxe de Método).:[{listaDecrescente.ToListString()}]");
            AguardaUsuario();

            Console.WriteLine($"Lista Inicial.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Primeiro elemento da Lista.:[{listaInteiros.FirstOrDefault()}]");
            AguardaUsuario();

            Console.WriteLine($"Lista Inicial.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Ultimo elemento da Lista.:[{listaInteiros.LastOrDefault()}]");
            AguardaUsuario();

            listaInteiros.Insert(0, 277);
            Console.WriteLine("Item: [277] adicionada na primeira posição da lista");
            Console.WriteLine($"Lista após inserção.:[{listaInteiros.ToListString()}]");
            AguardaUsuario();

            listaInteiros.Add(5);
            Console.WriteLine("Item: [5] adicionada na ultima posição da lista");
            Console.WriteLine($"Lista após inserção.:[{listaInteiros.ToListString()}]");
            AguardaUsuario();

            listaInteiros.Remove(listaInteiros.First());
            Console.WriteLine("Removendo o primeiro elemento da Lista");
            Console.WriteLine($"Lista após Remoção.:[{listaInteiros.ToListString()}]");
            AguardaUsuario();

            listaInteiros.Remove(listaInteiros.Last());
            Console.WriteLine("Removendo o último elemento da Lista");
            Console.WriteLine($"Lista após Remoção.:[{listaInteiros.ToListString()}]");
            AguardaUsuario();

            var listaNumeroPares = listaInteiros.Where(n => (n % 2) == 0).ToList();
            Console.WriteLine($"Lista Completa.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Lista com apenas numeros pares.:[{listaNumeroPares.ToListString()}]");
            AguardaUsuario();

            
            int numeroInformado = 78;
            var listaNumeroinformado = listaInteiros.Where(n => n == numeroInformado).ToList();
            Console.WriteLine($"Número informado.:[{numeroInformado}]");
            Console.WriteLine($"Lista Completa.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Lista com apenas o numero informado.:[{listaNumeroinformado.ToListString()}]");
            AguardaUsuario();

            int[] numeros = listaInteiros.ToArray();
            Console.WriteLine($"Lista Atual.:[{listaInteiros.ToListString()}]");
            Console.WriteLine($"Qtde de Itens no array.:[{numeros.Length}]");
            Console.WriteLine($"Itens do array.:[{string.Join(", ", numeros)}]");
            AguardaUsuario();

        }

        private static void AguardaUsuario()
        {
            Console.WriteLine("Preessione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
