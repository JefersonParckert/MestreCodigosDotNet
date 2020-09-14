using System;

namespace ExercicioPOO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Polimorfismo.Executar();

            Abstracao.Executar();

            Encapsulamento.ServirCafe();

            ClasseAbstrataXInterface.Executar();

            ExemploIDisposable.Executar();

            ExemploIComparable.Executar();

            ExemploIEnumerable.Executar();

            ExemploICloneable.Executar();

            Console.ReadKey();
        }
    }
}
