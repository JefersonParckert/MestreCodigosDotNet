using ExercicioPOO_4.Dominio.Interface;
using System;
using static ExercicioPOO_4.Uteis.Util;

namespace ExercicioPOO_4.Dominio
{
    public class Televisao: IAparelho
    {
        const int CANAL_MAXIMO = 999;
        const int CANAL_MINIMO = 0;

        const int VOLUME_MAXIMO = 100;
        const int VOLUME_MINIMO = 0;

        private int _volume;
        private int _canal;

        public Televisao()
        {
            _volume = VOLUME_MINIMO;
            _canal = CANAL_MINIMO;
        }

        public void ControlarVolume(TipoAcao tipoAcao)
        {
            AumentarVolume(tipoAcao);
            DiminuirVolume(tipoAcao);
            ImprimirVolume(tipoAcao);
        }

        private void AumentarVolume(TipoAcao tipoAcao)
        {
            if (tipoAcao != TipoAcao.Aumentar)
                return;

            if (_volume == VOLUME_MAXIMO)
                return;

            _volume++;
        }

        private void DiminuirVolume(TipoAcao tipoAcao)
        {
            if (tipoAcao != TipoAcao.Diminuir)
                return;

            if (_volume == VOLUME_MINIMO)
                return;

            _volume--;
        }

        private void ImprimirVolume(TipoAcao tipoAcao)
        {
            Console.WriteLine($"[TV] - Volume {PegarDescricaoAcao(tipoAcao)} para a potência: {_volume}");
        }

        public void ControlarCanal(TipoAcao tipoAcao)
        {
            AumentarCanal(tipoAcao);
            DiminuirCanal(tipoAcao);
            ImprimirCanal(tipoAcao);
        }

        private void AumentarCanal(TipoAcao tipoAcao)
        {
            if (tipoAcao != TipoAcao.Aumentar)
                return;

            if (_canal == CANAL_MAXIMO)
                return;

            _canal++;
        }

        private void DiminuirCanal(TipoAcao tipoAcao)
        {
            if (tipoAcao != TipoAcao.Diminuir)
                return;

            if (_canal == CANAL_MINIMO)
                return;

            _canal--;
        }

        private void ImprimirCanal(TipoAcao tipoAcao)
        {
            Console.WriteLine($"[TV] - Canal {PegarDescricaoAcao(tipoAcao)} para o canal: {_canal}");
        }

        public void DefinirCanal(int canal)
        {
            if (TestarCanalValido(canal))
            {
                _canal = canal;
                ImprimirCanal(TipoAcao.Definir);
                return;
            }

            ImprimirCanalInvalido(canal);
        }

        private void ImprimirCanalInvalido(int canal)
        {
            Console.WriteLine($"[TV] - O canal ({canal}) é inválido!");
        }

        private bool TestarCanalValido(int canal)
        {
            return (canal >= CANAL_MINIMO) && (canal <= CANAL_MAXIMO);            
        }

        public void ConsultarDefinicoes(out int canal, out int volume)
        {
            canal = _canal;
            volume = _volume;
        }
    }
}
