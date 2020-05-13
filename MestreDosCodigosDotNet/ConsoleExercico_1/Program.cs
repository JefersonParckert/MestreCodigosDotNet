using ConsoleExercicio_1.RegraNegocio;
using ConsoleExercicio_1.Uteis;
using System;

namespace ConsoleExercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = CriarMenu();
            double valor1 = PegarValor("Valor 1");
            double valor2 = PegarValor("Valor 2");
            do
            {
                var calculo = new CalculoFactory(menu.PegarOpcaoUsuario()).CriarCalculo();

                if (calculo != null)
                {
                    calculo.ExecutarCalculo(valor1, valor2);
                    ExebirResultado(calculo.PegarResultado());
                }
            } while (menu.UltimaOpcaoSelecionada != Constantes.OPCAO_SAIR);
        }

        private static void ExebirResultado(string resultado)
        {
            Console.Clear();
            Console.WriteLine("************ RESULTADO ************");
            Console.WriteLine(resultado);
            Console.WriteLine("pressione qualquer tecla para continuar! ");
            Console.ReadKey();
        }

        private static Menu CriarMenu()
        {
            Menu menu = new Menu();

            PopularMenu(menu);

            return menu;
        }

        private static void PopularMenu(Menu menu)
        {
            menu.AdicionarItem("1", "Somar");
            menu.AdicionarItem("2", "Subtrair");
            menu.AdicionarItem("3", "Multiplicar");
            menu.AdicionarItem("4", "Dividir");
            menu.AdicionarItem("0", "Sair");
        }

        private static double PegarValor(string nomeParametro)
        {
            do
            {
                ExibirMensagemEntradaUsuario(nomeParametro);

                var valor = Console.ReadLine().ToDouble(Constantes.NUMERO_INDEFINIDO);

                var entradaCorreta = (valor != Constantes.NUMERO_INDEFINIDO);
                if (entradaCorreta)
                    return valor;

                ExibirNumeroInvalido();
                Console.ReadKey();

            } while (true);
        }

        private static void ExibirMensagemEntradaUsuario(string nomeParametro)
        {
            Console.Clear();
            Console.WriteLine($"Informe o {nomeParametro}");
        }

        private static void ExibirNumeroInvalido()
        {
            Console.Clear();
            Console.WriteLine("O número informado não é valido");
            Console.WriteLine("pressione qualque tecla para continuar ");
        }
    }
}
