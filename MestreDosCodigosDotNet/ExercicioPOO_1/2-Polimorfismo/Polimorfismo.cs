using System;

namespace ExercicioPOO_1
{
    /*
     Polimorfismo significa que a chamada de um método que possui a mesma assinatura,
     pode ser executada de várias formas ou polimorficamente, 
     quem decide a forma de executar é o método chamado 
    */
    public static class Polimorfismo
    {
        public static void Executar()
        {
            Console.WriteLine("========== Polimorfismo ===========");
            Eletrodomestico geladeira = new Geladeira();
            geladeira.Ligar();
            geladeira.Desligar();

            Eletrodomestico forno = new Forno();
            forno.Ligar();
            forno.Desligar();

            Console.WriteLine();
        }
    }
}