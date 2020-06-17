using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO_3.Dominio
{
    public abstract class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
            NumeroConta = 0;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroConta, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public abstract string Sacar(double valorSaque);
        public abstract string Depositar(double valorDeposito);

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

        public void AtualizarSaldo(double valorAtualizar)
        {
            Saldo += valorAtualizar;   
        }

        public string PegarMensagemStatusTransacao(StatusTransacao status)
        {
            switch (status)
            {
                case StatusTransacao.Sucesso:
                    return "Transação Realizada com Sucesso!";
                case StatusTransacao.SaldoInsuficiente:
                    return "Saldo insuficiente!";
                case StatusTransacao.ValorIncorreto:
                    return "O Valor da transação deve ser maior que zero!";
                default:
                    return "Status desconhecido!";
            }
        }

        public enum StatusTransacao 
        { 
            Sucesso,
            SaldoInsuficiente,
            ValorIncorreto
        }
    }
}
