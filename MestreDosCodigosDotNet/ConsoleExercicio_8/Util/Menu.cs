using System;
using System.Collections.Generic;

namespace ConsoleExercicio_8.Util
{
    public class Menu
    {
        private Dictionary<string, string> _opcoesMenu;
        public string OpcaoSelecioanda { get; private set; }

        public Menu()
        {
            _opcoesMenu = new Dictionary<string, string>();
            OpcaoSelecioanda = string.Empty;
        }

        public void AdicionarItem(string codigo, string descricao)
        {
            if (TestarOpcaoCadastrada(codigo))
                throw new Exception($" A opção ('{codigo}') já esta cadastrada!");

            _opcoesMenu.Add(codigo, descricao);
        }

        public bool TestarOpcaoCadastrada(string codigo, out OpcoesMenu opcaoMenuSelecionada)
        {
            opcaoMenuSelecionada = OpcoesMenu.OpcaoInvalida;
            if (!TestarOpcaoCadastrada(codigo))
                return false;

            opcaoMenuSelecionada = (OpcoesMenu)Convert.ToInt32(codigo);
            return true;
        }

        private bool TestarOpcaoCadastrada(string codigo)
        {
            return _opcoesMenu.ContainsKey(codigo);            
        }

        public string PegarOpcoesMenu()
        {
            string opcoes = "========== MENU ========== \r\n";
            foreach (KeyValuePair<string, string> opcao in _opcoesMenu)
                opcoes += $"{opcao.Key} - {opcao.Value} \r\n";

            opcoes += "======== Digite a opção desejada ========";

            return opcoes;
        }

        public enum OpcoesMenu
        {
            Sair,
            CadastrarNumeros,
            ListarOrdemCrescente,
            ListarOrdenDecrescente,
            OpcaoInvalida = 999
        }

    }
}
