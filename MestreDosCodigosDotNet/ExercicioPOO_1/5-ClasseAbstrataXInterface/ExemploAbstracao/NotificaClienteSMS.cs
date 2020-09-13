using System;

namespace ExercicioPOO_1.ExemploAbstracao
{
    public class NotificaClienteSMS: NotificaClienteBase
    {
        public NotificaClienteSMS(string nome, string notificacao) : base(nome, notificacao)
        {
        }

        public override void NotificarCliente()
        {
            EnviarSMS();
        }

        private void EnviarSMS()
        {
            Console.WriteLine("A seguinte notificação foi enviada por SMS");
            Console.WriteLine(PegarMensagem());
        }
    }
}