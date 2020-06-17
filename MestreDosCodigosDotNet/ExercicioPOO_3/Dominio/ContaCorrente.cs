namespace ExercicioPOO_3.Dominio
{
    public class ContaCorrente : ContaBancaria
    {

        public double TaxaOperacao { get; private set; }

        public ContaCorrente(int numeroConta, double saldoInicial, double taxaOperacao)
            :base(numeroConta, saldoInicial)
        {
            TaxaOperacao = taxaOperacao;
        }

        public override string Depositar(double valorDeposito)
        {
            var statusTransacao = DepositoValido(valorDeposito);

            if (statusTransacao == StatusTransacao.Sucesso)
                AtualizarSaldo(valorDeposito - TaxaOperacao);

            return PegarMensagemStatusTransacao(statusTransacao);
        }

        public override string Sacar(double valorSaque)
        {
            var statusTransacao = SaqueValido(valorSaque);
            if (statusTransacao == StatusTransacao.Sucesso)
            {
                var valorSaqueComTaxa = valorSaque + TaxaOperacao;

                statusTransacao = SaqueValido(valorSaqueComTaxa);

                if (statusTransacao == StatusTransacao.Sucesso)
                    AtualizarSaldo(valorSaqueComTaxa * (-1));
            }
            return PegarMensagemStatusTransacao(statusTransacao);
        }
    }
}
