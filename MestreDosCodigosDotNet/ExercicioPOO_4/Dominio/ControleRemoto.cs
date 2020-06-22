using ExercicioPOO_4.Dominio.Interface;
using System;
using static ExercicioPOO_4.Uteis.Util;

namespace ExercicioPOO_4.Dominio
{
    public class ControleRemoto
    {
        delegate void ControleVolumeDelegate(TipoAcao tipoAcao);
        delegate void ControleCanalDelegate(TipoAcao tipoAcao);
        delegate void DefinirCanalDelegate(int canal);
        delegate void ConsultarDefinicoesDelegate(out int canal, out int volume);

        private ControleVolumeDelegate _controlarVolume;
        private ControleCanalDelegate _controlarCanal;
        private DefinirCanalDelegate _definirCanal;
        private ConsultarDefinicoesDelegate _consultarDefinicoes;

        public void SincronizarAparelho(IAparelho televisao)
        {
            _controlarVolume += televisao.ControlarVolume;
            _controlarCanal += televisao.ControlarCanal;
            _definirCanal += televisao.DefinirCanal;
            _consultarDefinicoes += televisao.ConsultarDefinicoes;
        }

        private bool TestarAparelhosSincronizados()
        {
            if ((_controlarVolume != null) && (_controlarCanal != null) && 
                (_definirCanal != null) && (_consultarDefinicoes != null))
                return true;

            NotificarControleNaoSincronizado();
            return false;
        }

        private void NotificarControleNaoSincronizado()
        {
            Console.WriteLine("O Controle remoto não está sincronizado com a TV");
        }

        public void AumentarVolume()
        {
            AlterarVolume(TipoAcao.Aumentar);
        }
                
        public void DiminuirVolume()
        {
            AlterarVolume(TipoAcao.Diminuir);
        }

        private void AlterarVolume(TipoAcao tipoAcao)
        {
            if (TestarAparelhosSincronizados())
                _controlarVolume(tipoAcao);            
        }

        public void AumentarCanal()
        {
            AlterarCanal(TipoAcao.Aumentar);
        }

        public void DiminuirCanal()
        {
            AlterarCanal(TipoAcao.Diminuir);
        }

        private void AlterarCanal(TipoAcao tipoAcao)
        {
            if (TestarAparelhosSincronizados())
                _controlarCanal(tipoAcao);            
        }

        public void DefinirCanal(int canal)
        {
            if (TestarAparelhosSincronizados())
                _definirCanal(canal);
        }

        public void ConsultarDefinicoes()
        {
            if (!TestarAparelhosSincronizados())
                return;

            _consultarDefinicoes(out int canal, out int volume);
            Console.WriteLine($"[Controle] - Definições da TV, Volume.:{volume}, Canal.: {canal}");
        }
    }
}
