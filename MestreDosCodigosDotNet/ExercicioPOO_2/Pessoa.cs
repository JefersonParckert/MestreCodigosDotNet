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
                if (value.Date > DateTime.Now.Date)
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
            return $"Nome: {_nome}, {PegarIdadePessoa(DateTime.Now)} ano(s) \nData Nascimento.: {_dataNascimento.ToShortDateString()} \nAltura.: {_altura:N2}";
        }

        public int PegarIdadePessoa(DateTime dataCorrente) {
            int idade = (dataCorrente.Year - _dataNascimento.Year);
            if (dataCorrente.Month < _dataNascimento.Month)
                idade--;

            if ((dataCorrente.Month == _dataNascimento.Month) && (dataCorrente.Day < _dataNascimento.Day))
                idade--;

            return idade;
        }
    }
}
