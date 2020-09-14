using System;
using System.Collections;

namespace ExercicioPOO_1
{
    /*Essa interface é implementada por tipos cujos valores podem ser ordenados ou classificados.
     Ele requer que os tipos de implementação definam um único método, CompareTo(Object) , 
    que indica se a posição da instância atual na ordem de classificação é anterior, 
    posterior ou igual a um segundo objeto do mesmo tipo. A implementação da instância IComparable 
    é chamada automaticamente por métodos como Array.Sort e ArrayList.Sort .
   */

    public static class ExemploIComparable
    {
        public static void Executar()
        {
            Console.WriteLine("========== IComparable ===========");
            var mensagens = new ArrayList();
            mensagens.Add(new Mensagem("Mensagem A", DateTime.Now));
            mensagens.Add(new Mensagem("Mensagem B", DateTime.Now.AddDays(20)));
            mensagens.Add(new Mensagem("Mensagem C", DateTime.Now.AddDays(-10)));

            mensagens.Sort();

            foreach (Mensagem msg in mensagens)
            {
                Console.WriteLine(msg.ToString());
            }

            Console.WriteLine();
        }
    }
}