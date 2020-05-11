using ConsoleExercico_1.Interfaces;
using ConsoleExercico_1.Uteis;

namespace ConsoleExercico_1.RegraNegocio
{
    public class Subtracao : CalculoBase, ICalculo
    {
        protected override string PegarSimboloOperacao()
        {
            return Constantes.SIMBOLO_SUBTRACAO;
        }

        protected override double Calcular()
        {
            return Valor1 - Valor2;
        }
    }
}
