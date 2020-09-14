using System;

namespace ExercicioPOO_1
{
    public class Mensagem : IComparable, ICloneable
    {
        public string Descricao { get; set; }
        public DateTime DataEnvio { get; set; }


        public Mensagem(string descricao, DateTime dataEnvio)
        {
            Descricao = descricao;
            DataEnvio = dataEnvio;
        }

        //implementação do IComparable, retorna:
        // < 0 se se a instância Atual é menor que o objeto especificado pelo CompareTo
        // = 0 se se a instância Atual é igual ao objeto especificado pelo CompareTo
        // > 0 se se a instância Atual é maior que o objeto especificado pelo CompareTo
        public int CompareTo(object? obj)
        {
            if (obj == null)
                return 1;

            var mensagem = obj as Mensagem;

            return this.DataEnvio.CompareTo(mensagem.DataEnvio);
        }

        public override string ToString()
        {
            return $"Mensagem: [{Descricao}] enviada em: {DataEnvio}";
        }

        //implementação do ICloneable, Cria uma cópia do objeto
        public object Clone()
        {
            return (Mensagem)this.MemberwiseClone();
        }
    }
}