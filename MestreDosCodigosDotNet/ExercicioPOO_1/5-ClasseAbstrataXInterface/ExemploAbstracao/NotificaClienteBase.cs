namespace ExercicioPOO_1.ExemploAbstracao
{
    public abstract class NotificaClienteBase
    {

        private readonly string _nome;
        private readonly string _notificacao;

        protected NotificaClienteBase(string nome, string notificacao)
        {
            _nome = nome;
            _notificacao = notificacao;
        }

        protected string PegarMensagem()
        {
            return $"Atenção sr(a): {_nome}! {_notificacao}";
        }

        public abstract void NotificarCliente();
    }
}