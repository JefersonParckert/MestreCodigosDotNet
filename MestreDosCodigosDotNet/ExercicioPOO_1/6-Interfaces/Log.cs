using System;
using System.IO;
using System.Text;

namespace ExercicioPOO_1
{
    public class Log: IDisposable
    {
        private readonly FileStream _fileStream;

        public Log(string nomeArquivo)
        {
            _fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate, FileAccess.Write);
        }

        public void GravarLog(string log)
        {
            byte[] dados = Encoding.ASCII.GetBytes(log);

            _fileStream.Write(dados, 0, dados.Length);
        }

        public void Dispose()
        {
            _fileStream?.Close();
            _fileStream?.Dispose();
        }
    }
}