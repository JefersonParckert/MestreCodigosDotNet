using System;
using System.Collections.Generic;
using System.Linq;
using static ExercicioPOO_3.Uteis.Tipos;

namespace ExercicioPOO_3.Dominio
{
    public abstract class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        protected List<Transacao> _transacoes;

        public ContaBancaria(int numeroConta, double saldoInicial)
        {
            _transacoes = new List<Transacao>();
            NumeroConta = numeroConta;
            Saldo = saldoInicial;

            GravarTransacao(TipoTransacao.AberturaConta, saldoInicial, StatusTransacao.Sucesso);
        }

        public abstract void Sacar(double valorSaque);
        public abstract void Depositar(double valorDeposito);

        protected virtual double SaldoAtual()
        {
            return Saldo;
        }

        public StatusTransacao SaqueValido(double valorSaque)
        {
            if (valorSaque <= 0)
                return StatusTransacao.ValorIncorreto;

            return (valorSaque <= SaldoAtual()) 
                        ? StatusTransacao.Sucesso
                        : StatusTransacao.SaldoInsuficiente;
        }

        public StatusTransacao DepositoValido(double valorDeposito)
        {
            return (valorDeposito <= 0)
                        ? StatusTransacao.ValorIncorreto 
                        : StatusTransacao.Sucesso;            
        }

        public void RealizarTransacao(TipoTransacao tipoTransacao, double valorTransacao)
        {
            EfetuarCredito(tipoTransacao, valorTransacao);
            EfetuarDebito(tipoTransacao, valorTransacao);

            GravarTransacao(tipoTransacao, valorTransacao, StatusTransacao.Sucesso);
        }

        private void EfetuarCredito(TipoTransacao tipoTransacao, double valorTransacao)
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

        private void EfetuarDebito(TipoTransacao tipoTransacao, double valorTransacao)
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

        protected void GravarTransacao(TipoTransacao tipoTransacao, double valorTransacao, StatusTransacao statusTransacao)
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
