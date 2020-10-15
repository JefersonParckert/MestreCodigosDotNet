using ExercicioPOO_3.Dominio.Interface;
using System;
using static ExercicioPOO_3.Uteis.Tipos;

namespace ExercicioPOO_3.Dominio
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public decimal LimiteEspecial { get; private set; }

        public ContaEspecial(int numeroConta, decimal saldoInicial, decimal limiteEspecial) 
            : base(numeroConta, saldoInicial)
        {
            LimiteEspecial = limiteEspecial;
        }

        public override void Depositar(decimal valorDeposito)
        {
            var statusTransacao = DepositoValido(valorDeposito);

            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Deposito, valorDeposito, statusTransacao);
                return;
            }

            RealizarTransacao(TipoTransacao.Deposito, valorDeposito);
        }

        public override void Sacar(decimal valorSaque)
        {
            var statusTransacao = SaqueValido(valorSaque);
            if (statusTransacao != StatusTransacao.Sucesso)
            {
                GravarTransacao(TipoTransacao.Saque, valorSaque, statusTransacao);
                return;
            }

            RealizarTransacao(TipoTransacao.Saque, valorSaque);            
        }

        protected override decimal SaldoAtual()
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
