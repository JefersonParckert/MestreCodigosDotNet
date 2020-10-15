using System;
using System.Collections.Generic;
using System.Linq;
using static ExercicioPOO_3.Uteis.Tipos;

namespace ExercicioPOO_3.Dominio
{
    public abstract class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public decimal Saldo { get; private set; }

        protected List<Transacao> _transacoes;

        public ContaBancaria(int numeroConta, decimal saldoInicial)
        {
            _transacoes = new List<Transacao>();
            NumeroConta = numeroConta;
            Saldo = saldoInicial;

            GravarTransacao(TipoTransacao.AberturaConta, saldoInicial, StatusTransacao.Sucesso);
        }

        public abstract void Sacar(decimal valorSaque);
        public abstract void Depositar(decimal valorDeposito);

        protected virtual decimal SaldoAtual()
        {
            return Saldo;
        }

        public StatusTransacao SaqueValido(decimal valorSaque)
        {
            if (valorSaque <= 0)
                return StatusTransacao.ValorIncorreto;

            return (valorSaque <= SaldoAtual()) 
                        ? StatusTransacao.Sucesso
                        : StatusTransacao.SaldoInsuficiente;
        }

        public StatusTransacao DepositoValido(decimal valorDeposito)
        {
            return (valorDeposito <= 0)
                        ? StatusTransacao.ValorIncorreto 
                        : StatusTransacao.Sucesso;            
        }

        public void RealizarTransacao(TipoTransacao tipoTransacao, decimal valorTransacao)
        {
            EfetuarCredito(tipoTransacao, valorTransacao);
            EfetuarDebito(tipoTransacao, valorTransacao);

            GravarTransacao(tipoTransacao, valorTransacao, StatusTransacao.Sucesso);
        }

        private void EfetuarCredito(TipoTransacao tipoTransacao, decimal valorTransacao)
        {
            switch (tipoTransacao)
            {
                case TipoTransacao.AberturaConta:
                case TipoTransacao.Deposito:
                    Saldo += valorTransacao;
                    break;
                default: 
                    return;
            }
        }

        private void EfetuarDebito(TipoTransacao tipoTransacao, decimal valorTransacao)
        {
            switch (tipoTransacao)
            {
                case TipoTransacao.Saque:
                case TipoTransacao.TaxaOperacao:
                    Saldo -= valorTransacao;
                    break;
                default:
                    return;
            }
        }

        protected void GravarTransacao(TipoTransacao tipoTransacao, decimal valorTransacao, StatusTransacao statusTransacao)
        {
            var transacao = new Transacao();
            transacao.TipoTransacao = tipoTransacao;
            transacao.ValorTransacao = valorTransacao;
            transacao.SaldoAtual = Saldo;
            transacao.StatusTransacao = statusTransacao;

            _transacoes.Add(transacao);
        }

        protected void ImprimirExtrato()
        {
            if (!_transacoes.Any())
                return;

            Console.WriteLine("\n+++++  Extrato  +++++");
            foreach (Transacao transacao in _transacoes)
                Console.WriteLine(transacao.DadosTransacao());
        }
    }
}
