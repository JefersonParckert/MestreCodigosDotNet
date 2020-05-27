using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_9.Uteis
{
    public static class Extensao
    {

        /// <summary>
        /// Converte uma lista de nteiros em uma string com os itens separados por um separador
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="separador"></param>
        /// <returns>Retorna os itens em uma string separados pelo separador</returns>
        public static string ToListString(this List<int> lista, string separador = ", ")
        {
            if (!lista.Any())
                return "LISTA VAZIA";

            return String.Join(separador, lista);
        }
    }
}
