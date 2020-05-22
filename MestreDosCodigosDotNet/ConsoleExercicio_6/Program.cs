using System;

namespace ConsoleExercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //teste com out
            int valor1 = 10;
            int valor2 = 5;

            //não há necessidade de inicializarmos a variável pois o valor atribuido aqui, não será repassado para o método chamado
            int resultadoOut;
            CalcularSomaOut(valor1, valor2, out resultadoOut);
            Console.WriteLine($"Resultado da soma usando OUT = {resultadoOut}");
            Console.WriteLine();

            //Neste caso podemos inicializar a variável, pois ela será repassada para o método chamado
            int resultadoRef = 2;
            CalcularSomaOut(valor1, valor2, out resultadoRef);
            Console.WriteLine($"Resultado da soma usando OUT = {resultadoRef}");
            Console.ReadKey();
        }

        public static void CalcularSomaRef(int valor1, int valor2, ref int resultado)
        {
            //para parâmetros por referencia REF podemos utilizar ele antes de realizarmos qualquer atribuição
            //pois o valor atribuido no métdo que chamou será repassado para este método.
            Console.WriteLine($"Valor do parâmetro resultado antes do cáculo é igual a {resultado}");
            resultado = valor1 + valor2;        
        }

        public static void CalcularSomaOut(int valor1, int valor2, out int resultado)
        {
            //Quando utilizamos OUT não conseguimos imprimir o resultado  antes de atribuir valor para variável,
            // ou seja o valor atribuido para o parâmetro OUT no método que chamou não poderá ser utilizado, pois 
            // antes de usar o parâmetro do tipo OUT primeiro devemos realizar a atribuição do mesmo
            // caso descomentarmos a linha de comando abaixo, o compilador ira acusar erro, pois o parâmetro Out não foi inicializado
            //Console.WriteLine($"Valor do parâmetro resultado antes do cáculo é igual a {resultado}");
            resultado = valor1 + valor2;            
        }
    }
}
