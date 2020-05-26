using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_8.Util
{
    public static class Extensoes
    {
        public static double ToDoubleDef(this object valor, double defVal)
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

        public static string ToLista(this List<double> lista, Constantes.Ordenacao formaOrdenacao)
        {
            if (!lista.Any())
                return "LISTA VAZIA";

            List<double> listaInterna = lista;

            if (formaOrdenacao == Constantes.Ordenacao.Crescente)
                listaInterna = lista.OrderBy(n => n).ToList();

            if (formaOrdenacao == Constantes.Ordenacao.Decrescente)
                listaInterna = lista.OrderByDescending(n => n).ToList();

            return String.Join(" - ", listaInterna);
        }

        public static bool DoubleValido(this string valor)
        {
           return (valor.ToDoubleDef(Constantes.DOUBLE_INVALIDO) != Constantes.DOUBLE_INVALIDO);           
        }
    }
}
