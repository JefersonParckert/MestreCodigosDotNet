using System;

namespace ExercicioPOO_1
{
    /*A interface ICloneable permite que você forneça uma implementação personalizada que cria uma cópia de um objeto existente,
     elá requer que apenas o método Clone() seja implementado retornando uma cópia da instância do objeto atual*/
    public static class ExemploICloneable
    {
        public static void Executar()
        {
            Console.WriteLine("========== ICloneable ===========");
            
            var mensagemOriginal = new Mensagem("Ola", DateTime.Now);
            var mensagemClone = mensagemOriginal.Clone() as Mensagem;
            
            
            Console.WriteLine($"Mensagem Original: {mensagemOriginal.ToString()}");
            
            Console.WriteLine($"Mensagem Clonada: {mensagemClone.ToString()}");

            Console.WriteLine();
        }
    }
}