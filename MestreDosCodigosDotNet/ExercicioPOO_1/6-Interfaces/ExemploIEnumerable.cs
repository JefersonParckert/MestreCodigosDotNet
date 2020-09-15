using System;

namespace ExercicioPOO_1
{
    public static class ExemploIEnumerable
    {
        /*IEnumerable é uma interface que possibilita a iteração através do foreach por exemplo*/
        public static void Executar()
        {
            Console.WriteLine("========== IEnumerable ===========");
            Funcionario[] funcionarios = new Funcionario[]
            {
                new Funcionario("Jeferson", DateTime.Now.AddMonths(-15)),
                new Funcionario("Vanessa", DateTime.Now.AddDays(-180)),
                new Funcionario("Bianca", DateTime.Now.AddYears(-6))
            };

            var empresa = new Empresa(funcionarios);

            foreach (Funcionario funcionario in empresa)
            {
                Console.WriteLine(funcionario.ToString());    
            }
            
            Console.WriteLine();
        }
    }
}