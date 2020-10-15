using ConsoleExercicio_8.Util;
using System;
using System.Collections.Generic;

namespace ConsoleExercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = PegarMenu();
            List<double> listaNumeros = new List<double>();
            while (true)
            {
                Console.Clear();

                //metodos de ordenação disponível nos métodos de extensão
                Console.WriteLine($"Situação da Lista.: [{listaNumeros.ToLista(Constantes.Ordenacao.SemOrdenacao)}]");
                Console.WriteLine($"Lista em Ordem Crescente: [{listaNumeros.ToLista(Constantes.Ordenacao.Crescente)}]");
                Console.WriteLine($"Lista em Ordem Decrescente: [{listaNumeros.ToLista(Constantes.Ordenacao.Decrescente)}]\r\n");

                Console.WriteLine(menu.PegarOpcoesMenu());
                
                string opcaoDigitada = Console.ReadLine();

                Menu.OpcoesMenu opcaoSelecionada;
                if (!menu.TestarOpcaoCadastrada(opcaoDigitada, out opcaoSelecionada)) 
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida. Pressione ENTER para continuar!");
                    Console.ReadKey();
                }

                if (opcaoSelecionada == Menu.OpcoesMenu.Sair)
                    break;

                AdicionarNumeroLista(opcaoSelecionada, listaNumeros);                
            }
        }

        private static void AdicionarNumeroLista(Menu.OpcoesMenu opcaoSelecionada, List<double> listaNumeros)
        {
            if (opcaoSelecionada != Menu.OpcoesMenu.CadastrarNumeros)
                return;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Informe o número desejado!");
                string numeroDigitado = Console.ReadLine();
                if (numeroDigitado.DoubleValido())
                {
                    listaNumeros.Add(Convert.ToDouble(numeroDigitado));
                    break;
                }

                Console.Clear();
                Console.WriteLine("Número inválido! Pressione ENTER para continuar");
                Console.ReadKey();
            }
        }

        private static Menu PegarMenu()
        { 
            var menu = new Menu();
            menu.AdicionarItem("1", "Adicionar número");
            menu.AdicionarItem("0", "Sair");

            return menu;
        }       
    }
}
