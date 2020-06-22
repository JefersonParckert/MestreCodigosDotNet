using ExercicioPOO_4.Dominio;
using System;

namespace ExercicioPOO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var televisao = new Televisao();
            var controleRemoto = new ControleRemoto();

            controleRemoto.SincronizarAparelho(televisao);

            controleRemoto.AumentarVolume();
            controleRemoto.AumentarVolume();
            controleRemoto.AumentarVolume();
            controleRemoto.AumentarVolume();
            controleRemoto.DiminuirVolume();

            controleRemoto.DefinirCanal(550);
            controleRemoto.AumentarCanal();
            controleRemoto.DiminuirCanal();
            controleRemoto.DefinirCanal(9999);
            controleRemoto.ConsultarDefinicoes();

            Console.ReadKey();


        }
    }
}
