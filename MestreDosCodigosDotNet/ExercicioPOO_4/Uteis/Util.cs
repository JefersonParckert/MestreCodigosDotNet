using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO_4.Uteis
{
    public static class Util
    {
        public enum TipoAcao
        { 
            Indefinido,
            Aumentar,
            Diminuir,
            Definir
        }

        public static string PegarDescricaoAcao(TipoAcao tipoAcao)
        {
            switch (tipoAcao)
            {
                case TipoAcao.Aumentar: return "aumentado";
                case TipoAcao.Diminuir: return "diminuido";
                case TipoAcao.Definir: return "definido";
                default:
                    return "Ação desconhecida";
            }
        }
    }
}
