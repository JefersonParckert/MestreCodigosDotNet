using ConsoleExercicio_1.Interfaces;
using ConsoleExercicio_1.Uteis;
using System;

namespace ConsoleExercicio_1.RegraNegocio
{
    public class Divisao : CalculoBase, ICalculo
    {
        protected override string PegarSimboloOperacao()
        {
            return Constantes.SIMBOLO_DIVISAO;
        }

        protected override double Calcular()
        {
            ValidarNumeros();

            return Valor1 / Valor2;
        }

        private void ValidarNumeros()
        {
            if (Valor2 == 0)
                throw new DivideByZeroException();
        }
    }
}
