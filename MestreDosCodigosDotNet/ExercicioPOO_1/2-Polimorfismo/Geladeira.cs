using System;

namespace ExercicioPOO_1
{
    public class Geladeira : Eletrodomestico
    {
        private void IniciarResfriamento()
        {
            Console.WriteLine("Geladeira - Inciando Resfriamento");
        }

        private void FinalizarResfriamento()
        {
            Console.WriteLine("Geladeira - Finalizando Resfriamento");
        }

        public override void Ligar()
        {
            IniciarResfriamento();
        }

        public override void Desligar()
        {
            FinalizarResfriamento();
        }
    }
}