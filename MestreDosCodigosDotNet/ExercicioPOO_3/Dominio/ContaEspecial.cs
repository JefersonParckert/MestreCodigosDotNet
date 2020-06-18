using ExercicioPOO_3.Dominio.Interface;
using System;
using static ExercicioPOO_3.Uteis.Tipos;

namespace ExercicioPOO_3.Dominio
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double LimiteEspecial { get; private set; }

        public ContaEspecial(int numeroConta, double saldoInicial, double limiteEspecial) 
            : base(numeroConta, saldoInicial)
        {
            LimiteEspecial = limiteEspecial;
        }

        public override void Depositar(double valorDeposito)
        {
            var statusTransacao = DepositoValido(valorDeposito);

            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Deposito, valorDeposito, statusTransacao);
                return;
            }

            RealizarTransacao(TipoTransacao.Deposito, valorDeposito);
        }

        public override void Sacar(double valorSaque)
        {
            var statusTransacao = SaqueValido(valorSaque);
            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Saque, valorSaque, statusTransacao);
                return;
            }

            RealizarTransacao(TipoTransacao.Saque, valorSaque);            
        }

        protected override double SaldoAtual()
        {
            return (base.SaldoAtual() + LimiteEspecial);
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Numero Conta.: {base.NumeroConta}");
            Console.WriteLine($"Saldo Atual.: {base.Saldo:C2}");
            Console.WriteLine($"Limite Disponível.: {LimiteEspecial:C2}");
            Console.WriteLine($"Saldo com Limite.: {SaldoAtual():C2}");
            ImprimirExtrato();
        }
    }
}
