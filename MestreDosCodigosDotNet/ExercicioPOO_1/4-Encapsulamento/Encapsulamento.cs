using System;

namespace ExercicioPOO_1
{
    /*
     * Encapsulamento é a técnica que faz com que detalhes internos do funcionamento dos métodos de uma classe
     * permaneçam ocultos para os objetos, separando o programa em partes o mais isolado possível 
     */

    public static class Encapsulamento
    {
        public static void ServirCafe()
        {
            Console.WriteLine("========== Encapsulamento -> Servindo Café ===========");
            
            var cafeteira = new Cafeteira();
            cafeteira.Ligar();
            cafeteira.PrepararCafe();
            cafeteira.Desligar();

            Console.WriteLine();
        }
    }
}