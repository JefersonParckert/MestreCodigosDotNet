using ConsoleExercico_1.Interfaces;
using System;

namespace ConsoleExercico_1.RegraNegocio
{
    public class CalculoBase : ICalculo
    {
        protected double Valor1;
        protected double Valor2;
        protected double Resultado;

        private bool _executouCalculo;
        private string _mensagemErro;

        public void ExecutarCalculo(double valor1, double valor2)
        {
            try
            {
                Valor1 = valor1;
                Valor2 = valor2;
                _executouCalculo = true;
                _mensagemErro = string.Empty;

                Resultado = Calcular();
            }
            catch (DivideByZeroException)
            {
                _executouCalculo = false;
                _mensagemErro = "Erro ao realizar o calculo, divisão por zero não permitida";
            }
            catch (Exception)
            {
                _executouCalculo = false;
                _mensagemErro = "Erro ao realizar o calculo, erro não especificado!";
            }
        }

        protected virtual double Calcular()
        {
            return 0.0;
        }

        protected virtual string PegarSimboloOperacao()
        {
            return string.Empty;
        }

        private string RetornaDescricaoNumeroParOuImpar(double valor)
        {
            string tipoNumero = ((valor % 2.0) == 0.0) ? "PAR" : "IMPAR";

            return $"O número ({valor}) é {tipoNumero}";
        }

        private string RetornarTextoCalculo()
        {
            string resultado = Resultado.ToString("N4");
            if (!_executouCalculo)
                resultado = _mensagemErro;

            return $"Resultao do Cálculo: {Valor1} {PegarSimboloOperacao()} {Valor2} = {resultado}";
        }

        public string PegarResultado()
        {
            string textoValor1 = RetornaDescricaoNumeroParOuImpar(Valor1);
            string textoValor2 = RetornaDescricaoNumeroParOuImpar(Valor2);
            string textoCalculo = RetornarTextoCalculo();

            return $"{textoValor1}\r\n{textoValor2}\r\n{textoCalculo}\r\n"; ;
        }
    }
}
