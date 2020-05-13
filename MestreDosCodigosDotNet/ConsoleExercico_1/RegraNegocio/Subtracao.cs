using ConsoleExercicio_1.Interfaces;
using ConsoleExercicio_1.Uteis;

namespace ConsoleExercicio_1.RegraNegocio
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
