namespace ExercicioPOO_3.Uteis
{
    public static class Tipos
    {
        public enum TipoTransacao 
        { 
            AberturaConta,
            Saque,
            Deposito,
            TaxaOperacao
        }

        public enum StatusTransacao
        {
            Sucesso,
            SaldoInsuficiente,
            ValorIncorreto
        }

        public static string PegarDescricaoTipoTransacao(TipoTransacao transacao)
        {
            switch (transacao)
            {
                case TipoTransacao.AberturaConta: 
                    return "Abertura de Conta";
                case TipoTransacao.Saque:
                    return "Saque";
                case TipoTransacao.Deposito:
                    return "Deposito";
                case TipoTransacao.TaxaOperacao:
                    return "Taxa de operação";
                default:
                    return "Transacao Desconhecida";
            }
        }

        public static string PegarDescricaoStatusTransacao(StatusTransacao status)
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
    }
}
