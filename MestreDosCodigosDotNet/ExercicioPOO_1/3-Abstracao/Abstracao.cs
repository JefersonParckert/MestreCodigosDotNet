using System;

namespace ExercicioPOO_1
{
    /*
     * A ideia da Abstração na orientação a objetos é oferecer um conjunto de estados e comportamentos
     * que abstraem uma certa especialização
     */

    public static class Abstracao
    {
        public static void Executar()
        {
            Console.WriteLine("========== Abstração ===========");
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