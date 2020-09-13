namespace ExercicioPOO_1
{
    /*
    POO é um paradigma de programação baseado no conceito de objetos, e tem como objetivo aproximar 
    o manuseio das estruturas de um programa ao manuseio das coisas do mundo real.

    Este paradigma baseia-se principalmente em 2 conceitos “Classes” e “Objetos”
    */

    // Definição da classe
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            // Definição de Objeto
            var casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }

}