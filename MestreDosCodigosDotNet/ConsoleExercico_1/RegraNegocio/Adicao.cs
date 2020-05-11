using ConsoleExercico_1.Interfaces;
using ConsoleExercico_1.Uteis;

namespace ConsoleExercico_1.RegraNegocio
{
    public class Adicao : CalculoBase, ICalculo
    {
        protected override string PegarSimboloOperacao()
        {
            return Constantes.SIMBOLO_ADICAO;
        }

        protected override double Calcular()
        {
            return Valor1 + Valor2;
        }
    }
}
