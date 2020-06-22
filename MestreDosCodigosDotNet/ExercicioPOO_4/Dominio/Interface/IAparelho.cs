using static ExercicioPOO_4.Uteis.Util;

namespace ExercicioPOO_4.Dominio.Interface
{
    public interface IAparelho
    {
        void ControlarCanal(TipoAcao tipoAcao);
        void ControlarVolume(TipoAcao tipoAcao);
        void DefinirCanal(int canal);
        void ConsultarDefinicoes(out int canal, out int volume);

    }
}
