namespace ExercicioPOO_3.Dominio
{
    public class ContaEspecial : ContaBancaria
    {
        public double LimiteEspecial { get; private set; }

        public ContaEspecial(int numeroConta, double saldoInicial, double limiteEspecial) 
            : base(numeroConta, saldoInicial)
        {
            LimiteEspecial = limiteEspecial;
        }

        public override string Depositar(double valorDeposito)
        {
            var statusTransacao = DepositoValido(valorDeposito);

            if (statusTransacao == StatusTransacao.Sucesso)
                AtualizarSaldo(valorDeposito);

            return PegarMensagemStatusTransacao(statusTransacao);
        }

        public override string Sacar(double valorSaque)
        {
            var statusTransacao = SaqueValido(valorSaque);
            if (statusTransacao == StatusTransacao.Sucesso)
                AtualizarSaldo(valorSaque * (-1));
            
            return PegarMensagemStatusTransacao(statusTransacao);
        }

        protected override double SaldoAtual()
        {
            return (base.SaldoAtual() + LimiteEspecial);
        }
    }
}
