using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExercicio_1.Interfaces
{
    public interface ICalculo
    {
        void ExecutarCalculo(double valor1, double valor2);
        string PegarResultado();
    }
}
