using System;

namespace ConsoleExercicio_7.Uteis
{
    public static class Extensoes
    {
        public static double ToDouble(this object valor, double defVal)
        {
            try
            {
                return Convert.ToDouble(valor);
            }
            catch
            {
                return defVal;
            }
        }

        public static bool IsPair(this int valor)
        {
            return (valor % 2) == 0;
        }
    }
}
