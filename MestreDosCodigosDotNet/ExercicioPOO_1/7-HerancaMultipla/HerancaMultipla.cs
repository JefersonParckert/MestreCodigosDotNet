using System;
using System.Collections.Specialized;

namespace ExercicioPOO_1
{
    /*Não há Herança multipla de classe em c#, caso tentarmos criar uma classe que herda de 2 outras classes o compilador
     não irá compilar, ira gerar um erro avisando que a classe em questão possui multiplas classes base*/
    public class HerancaMultipla : PrimeiraClasseBase/*, SegundaClasseBase*/
    {
        public override void Imprimir()
        {
            Console.WriteLine("Imprimindo");
        }

        //public override string Ler()
        //{
        //    return string.Empty.
        //}   
    }
}