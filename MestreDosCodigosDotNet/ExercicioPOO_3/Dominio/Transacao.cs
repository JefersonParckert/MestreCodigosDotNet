using static ExercicioPOO_3.Uteis.Tipos;

namespace ExercicioPOO_3.Dominio
{
    public class Transacao
    {
        public TipoTransacao TipoTransacao { get; set; }
        public double ValorTransacao { get; set; }
        public double SaldoAtual { get; set; }
        public StatusTransacao StatusTransacao { get; set; }


        public string DadosTransacao()
        {
            return $"Transação: {PegarDescricaoTipoTransacao(TipoTransacao)}" +
                   $"\nValor da Transação: {ValorTransacao:C2}" +
                   $"\nSaldo Atual: {SaldoAtual:C2}" +
                   $"\nStatus Transacao: {PegarDescricaoStatusTransacao(StatusTransacao)}\n";
        }
    }
}
