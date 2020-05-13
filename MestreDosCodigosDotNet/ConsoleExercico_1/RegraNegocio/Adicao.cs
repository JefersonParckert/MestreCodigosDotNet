using ConsoleExercicio_1.Interfaces;
using ConsoleExercicio_1.Uteis;

namespace ConsoleExercicio_1.RegraNegocio
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
