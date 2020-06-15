using System;

namespace ExercicioPOO_2
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _dataNascimento;
        private double _altura;

        public Pessoa()
        {
            InicializarDados(string.Empty, DateTime.MinValue, 0.0);
        }

        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            InicializarDados(nome, DateTime.MinValue, 0.0);

            DataNascimento = dataNascimento;
            Altura = altura;
        }

        private void InicializarDados(string nome, DateTime dataNascimento, double altura) 
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _altura = altura;
        }
        
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("A Data de Nascimento deve ser menor que HOJE!");

                _dataNascimento = value;
            }
        }

        public double Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("A altura deve ser maior que ZERO!");

                _altura = value;
            }
        }

        public override string ToString()
        {
            return $"Nome: {_nome}, {IdadePessoa()} ano(s) \nData Nascimento.: {_dataNascimento.ToShortDateString()} \nAltura.: {_altura:N2}";
        }

        public int IdadePessoa() {
            int idade = (DateTime.Now.Year - _dataNascimento.Year);
            if (DateTime.Now.Month < _dataNascimento.Month)
                idade--;

            if ((DateTime.Now.Month == _dataNascimento.Month) && (DateTime.Now.Day < _dataNascimento.Day))
                idade--;

            return idade;
        }
    }
}
