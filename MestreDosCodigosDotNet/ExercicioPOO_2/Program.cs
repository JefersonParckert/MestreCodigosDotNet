using System;

namespace ExercicioPOO_2
{
    class Program
    {
        static void Main(string[] args)
        {
                var pessoa1 = new Pessoa();
                pessoa1.Nome = "Jeferson";
                pessoa1.Altura = 1.8;
                pessoa1.DataNascimento = new DateTime(1984, 03, 02);
                Console.WriteLine(pessoa1);

                Console.WriteLine();
                var pessoa2 = new Pessoa("Vanessa", new DateTime(1984, 10, 06), 1.68);
                Console.WriteLine(pessoa2);

            try
            { 
                Console.WriteLine();
                var pessoa3 = new Pessoa("Bianca", new DateTime(2021, DateTime.Now.Month, DateTime.Now.Day), 1.20);
                Console.WriteLine(pessoa3);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Erro ao Criar a 3ª pessoa.");
                Console.WriteLine($"ERRO.: {e.Message}");
            }
        }
    }
}
