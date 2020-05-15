using System;

namespace ConsoleExercicio_5.RegraNegocio
{
    class FormulaBhaskara
    {
        private double _delta;

        public double R1 { get; private set; }
        public double R2 { get; private set; }

        public string Resultado {
            get 
            {
                return PegarResultado();
            }
        }

        private string PegarResultado()
        {
            if (_delta < 0)
                return "O delta é menor que zero, a equação não possui valores reais";

            if (_delta > 0)
                return $"Resultado R1={R1:N2} e R2={R2:N2}";

            return $"O delta é igual a zero, a equação terá somente um valor. Resultado={R1:N2}";
        }

        public void Calcular(double valorA, double valorB, double valorC)
        {
            _delta = PegarDelta(valorA, valorB, valorC);
            if (_delta < 0)
                return;

            double divisor = PegarDivisor(valorA);
            if (Math.Abs(_delta) == 0)
            {
                R1 = PegarR1(valorB, _delta, divisor);
                R2 = R1;
            }

            double raizDelta = PegarRaizDelta(_delta);
            R1 = PegarR1(valorB, raizDelta, divisor);
            R2 = PegarR2(valorB, raizDelta, divisor);
        }

        private double PegarR2(double valorB, double raizDelta, double divisor)
        {
            return (-valorB - raizDelta) / divisor;
        }

        private double PegarR1(double valorB, double raizDelta, double divisor)
        {
            return (-valorB + raizDelta) / divisor;
        }

        private double PegarRaizDelta(double delta)
        {
            return Math.Sqrt(delta);
        }

        private double PegarDelta(double valorA, double valorB, double valorC)
        {
            return (Math.Pow(valorB, 2.0) - (4.0 * valorA * valorC));       
        }

        private double PegarDivisor(double valorA)
        {
            return (2.0 * valorA);
        }
    }
}
