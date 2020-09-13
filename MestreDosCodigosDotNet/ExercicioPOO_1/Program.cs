using System;

namespace ExercicioPOO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
                O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
                Existe herança múltipla (de classes) em C#?
             *
             */
            
            Polimorfismo.Executar();

            Abstracao.Executar();

            Encapsulamento.ServirCafe();

            ClasseAbstrataXInterface.Executar();

            Console.ReadKey();
        }
    }
}
