using System;

namespace ExercicioPOO_1
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public DateTime DataContratacao { get; set; }

        public Funcionario(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataContratacao = dataNascimento;    
        }

        public override string ToString()
        {
            return $"{Nome} foi contratado em {DataContratacao:dd/MM/yyyy}";
        }
    }
}