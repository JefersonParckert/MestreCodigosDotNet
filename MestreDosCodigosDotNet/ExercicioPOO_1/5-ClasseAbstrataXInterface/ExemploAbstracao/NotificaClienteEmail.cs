using System;

namespace ExercicioPOO_1.ExemploAbstracao
{
    public class NotificaClienteEmail : NotificaClienteBase
    {
        public NotificaClienteEmail(string nome, string notificacao) : base(nome, notificacao)
        {
        }

        public override void NotificarCliente()
        {
            EnviarEmail();
        }

        private void EnviarEmail()
        {
            Console.WriteLine("A seguinte notificação foi enviada por E-mail");
            Console.WriteLine(PegarMensagem());
        }
    }
}