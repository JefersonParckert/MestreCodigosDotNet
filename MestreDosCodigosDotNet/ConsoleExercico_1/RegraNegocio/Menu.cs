using System;
using System.Collections.Generic;

namespace ConsoleExercico_1.RegraNegocio
{
    public class Menu
    {
        private Dictionary<string, string> _opcoesMenu;
        private string _opcaoSelecionadaUsuario;

        public Menu()
        {
            _opcoesMenu = new Dictionary<string, string>();
            _opcaoSelecionadaUsuario = string.Empty;
        }

        public void AdicionarItem(string codigo, string descricao)
        {
            if (TestarOpcaoCadastrada(codigo))
                throw new Exception($" A opção ('{codigo}') já esta cadastrada!");

            _opcoesMenu.Add(codigo, descricao);
        }

        private void ListarOpcoesMenu()
        {
            Console.Clear();
            Console.WriteLine();
            foreach (KeyValuePair<string, string> opcao in _opcoesMenu)
                Console.WriteLine($"{opcao.Key} - {opcao.Value}");

            Console.WriteLine("Digite o código da opção desejada");
            Console.WriteLine();
        }

        private void PegarEntradaUsuario()
        {
            _opcaoSelecionadaUsuario = Console.ReadLine();
        }

        private bool TestarOpcaoCadastrada(string codigo)
        {
            return _opcoesMenu.ContainsKey(codigo);
        }

        private bool TestarOpcaoCadastrada()
        {
            return TestarOpcaoCadastrada(_opcaoSelecionadaUsuario);
        }

        private void ValidarEntradaUsuario()
        {
            if (TestarOpcaoCadastrada())
                return;

            ExibirMensagemOpcaoInvalida();
        }

        private void ExibirMensagemOpcaoInvalida()
        {
            Console.Clear();
            Console.WriteLine("Atenção, opção Invalida!");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }

        public int PegarOpcaoUsuario()
        {
            do
            {
                ListarOpcoesMenu();

                PegarEntradaUsuario();

                ValidarEntradaUsuario();

            } while (!TestarOpcaoCadastrada());

            return UltimaOpcaoSelecionada;
        }

        public int UltimaOpcaoSelecionada
        {
            get
            {
                return Convert.ToInt32(_opcaoSelecionadaUsuario);
            }
        }

    }
}
