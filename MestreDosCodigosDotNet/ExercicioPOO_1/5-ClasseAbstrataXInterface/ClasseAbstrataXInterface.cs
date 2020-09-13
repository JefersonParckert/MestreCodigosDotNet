using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using ExercicioPOO_1.ExemploAbstracao;
using ExercicioPOO_1.ExemploInterface;

namespace ExercicioPOO_1
{
    /*
     * 1) Quando usar uma classe abstrata?
     * -> Podemos utilizar classe abstrata, quando dentre um conjunto de classes do mesmo escopo, temos métodos em comum
     * -  ou seja com o mesmo comportamento, porem outros com funcionalidades especificas, desta forma podemos criar uma
     * -  classe base abstrata implementando os métodos em comun e deixando os demais como abstratos para as classes filhas
     * - definirem seu comportamento
     *
     * 2) Quando usar uma interface?
     * -> Devemos usar interfaces, quando temos um conjunto de classes que possuem os mesmos aspectos, porem suas implementações
     * - porem suas implementações são distintas, neste caso podemos especificar uma interface que seria um documento ou protocolo,
     * - porem cabe a cada classe definir como será realizada a implementação.
    */


    public static class ClasseAbstrataXInterface
    {
        public static void Executar()
        {
            
            Console.WriteLine("========== Classe Abstrat x Interface ===========");
            var notificaSMS = new NotificaClienteSMS("Jeferson", "Temos uma grande promoção para você!");
            notificaSMS.NotificarCliente();

            var notificaEmail = new NotificaClienteEmail("Jeferson", "Temos uma grande promoção para você!");
            notificaEmail.NotificarCliente();


            Console.WriteLine();
            List<string> lista = new List<string>() {"D", "A", "J"};
            var ordemcrescente = new OrdemCrescente();
            ordemcrescente.Ordenar(lista);

            var ordemdecrescente = new OrdemDecrescente();
            ordemdecrescente.Ordenar(lista);

        }
    }
}
