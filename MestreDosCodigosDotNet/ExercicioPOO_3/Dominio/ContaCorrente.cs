using ExercicioPOO_3.Dominio.Interface;
using System;
using static ExercicioPOO_3.Uteis.Tipos;

namespace ExercicioPOO_3.Dominio
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {

        public decimal TaxaOperacao { get; private set; }

        public ContaCorrente(int numeroConta, decimal saldoInicial, decimal taxaOperacao)
            :base(numeroConta, saldoInicial)
        {
            TaxaOperacao = taxaOperacao;
        }

        public override void Depositar(decimal valorDeposito)
        {
            var statusTransacao = DepositoValido(valorDeposito);

            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Deposito, valorDeposito, statusTransacao);
                return;
            }

            ExecutarMovimentacao(TipoTransacao.Deposito, valorDeposito);
        }

        public override void Sacar(decimal valorSaque)
        {
            var statusTransacao = SaqueValido(valorSaque);
            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Saque, valorSaque, statusTransacao);
                return;
            }

            var valorSaqueComTaxa = valorSaque + TaxaOperacao;
            statusTransacao = SaqueValido(valorSaqueComTaxa);
            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Saque, valorSaque, statusTransacao);
                return;
            }

            ExecutarMovimentacao(TipoTransacao.Saque, valorSaque);
        }

        private void ExecutarMovimentacao(TipoTransacao tipoTransacao, decimal valorMovimentacao)
        {
            RealizarTransacao(tipoTransacao, valorMovimentacao);
            RealizarTransacao(TipoTransacao.TaxaOperacao, TaxaOperacao);
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Numero Conta.: {base.NumeroConta}");
            Console.WriteLine($"Saldo Atual.: {base.Saldo:C2}");
            Console.WriteLine($"Taxa por operação.: {TaxaOperacao:C2}");
            ImprimirExtrato();
        }
    }
}
