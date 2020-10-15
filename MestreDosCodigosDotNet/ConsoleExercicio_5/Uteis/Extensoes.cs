using System;

namespace ConsoleExercicio_5.Uteis
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
    }
}
