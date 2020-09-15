using System;

namespace ExercicioPOO_1
{
    /*A principal utilização da interface IDisposible é liberar recursos não gerenciados, permitindo o uso do using */
    public static class ExemploIDisposable
    {
        public static void Executar()
        {
            Console.WriteLine("========== IDisposable ===========");
            Console.WriteLine("Gravando logs! Por favor aguarde!");
            using (Log log = new Log($"ArquivoLog_{Guid.NewGuid()}.txt"))
            {
                log.GravarLog(" Primeiro Log ");
                log.GravarLog(" Segundo Log ");
            }
            Console.WriteLine("Logs Gravados com sucesso!");
            Console.WriteLine();
        }
    }
}