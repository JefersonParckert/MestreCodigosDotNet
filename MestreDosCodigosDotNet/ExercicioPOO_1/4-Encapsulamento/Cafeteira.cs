using System;

namespace ExercicioPOO_1
{
    public class Cafeteira : Eletrodomestico
    {
        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Console.WriteLine("Preparando café");
            AquecerAgua();
            MoerGraos();
        }

        
        public override void Ligar()
        {
            Console.WriteLine("Ligando");
        }

        public override void Desligar()
        {
            Console.WriteLine("Desligando");
        }
    }
}