using ConsoleExercicio_8.Util;
using System;
using System.Collections.Generic;
using System.Linq;

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
                LimparTela();

                //metodos de ordenação disponível nos métodos de extensão
                ImprimirTexto($"Situação da Lista.: [{listaNumeros.ToLista(Constantes.Ordenacao.SemOrdenacao)}]");
                ImprimirTexto($"Lista em Ordem Crescente: [{listaNumeros.ToLista(Constantes.Ordenacao.Crescente)}]");
                ImprimirTexto($"Lista em Ordem Decrescente: [{listaNumeros.ToLista(Constantes.Ordenacao.Decrescente)}]\r\n");

                ImprimirTexto(menu.PegarOpcoesMenu());
                
                string opcaoDigitada = Console.ReadLine();

                Menu.OpcoesMenu opcaoSelecionada;
                if (!menu.TestarOpcaoCadastrada(opcaoDigitada, out opcaoSelecionada)) 
                {
                    LimparTela();
                    ImprimirTexto("Opção Inválida. Pressione ENTER para continuar!");
                    AguardarUsuario();
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
                LimparTela();
                ImprimirTexto("Informe o número desejado!");
                string numeroDigitado = PegarOpcaoUsuario();
                if (numeroDigitado.DoubleValido())
                {
                    listaNumeros.Add(Convert.ToDouble(numeroDigitado));
                    break;
                }

                LimparTela();
                ImprimirTexto("Número inválido! Pressione ENTER para continuar");
                AguardarUsuario();
            }
        }

        private static void AguardarUsuario()
        {
            Console.ReadKey();
        }

        private static void LimparTela() 
        {
            Console.Clear();
        }

        private static void ImprimirTexto(string texto)
        {
            Console.WriteLine(texto);
        }

        private static string PegarOpcaoUsuario()
        { 
            return Console.ReadLine();
        }

        private static Menu PegarMenu()
        { 
            var menu = new Menu();
            PopularMenu(menu);

            return menu;
        }

        private static void PopularMenu(Menu menu)
        {
            menu.AdicionarItem("1", "Adicionar número");
            menu.AdicionarItem("0", "Sair");
        }
    }
}
