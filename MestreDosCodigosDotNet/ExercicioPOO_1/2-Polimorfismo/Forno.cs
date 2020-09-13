using System;

namespace ExercicioPOO_1
{
    public class Forno: Eletrodomestico
    {
        private void IniciarAquecimento()
        {
            Console.WriteLine("Forno - Inciando Aquecimento");
        }

        private void FinalizarAquecimento()
        {
            Console.WriteLine("Forno - Finalizando Aquecimento");
        }

        public override void Ligar()
        {
            IniciarAquecimento();
        }

        public override void Desligar()
        {
            FinalizarAquecimento();
        }
    }
}