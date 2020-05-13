using ConsoleExercicio_1.Interfaces;

namespace ConsoleExercicio_1.RegraNegocio
{
    public class CalculoFactory
    {

        private readonly OpcoesCalculo _opcaoCalculo;
        public CalculoFactory(int opcaoCalculo)
        {
            _opcaoCalculo = (OpcoesCalculo)opcaoCalculo;
        }

        public ICalculo CriarCalculo()
        {
            switch (_opcaoCalculo)
            {
                case OpcoesCalculo.opcaoSomar: return new Adicao();
                case OpcoesCalculo.opcaoSubtrair: return new Subtracao();
                case OpcoesCalculo.opcaoMultiplicar: return new Multiplicacao();
                case OpcoesCalculo.opcaoDividir: return new Divisao();
                default: return null;
            }
        }

        public enum OpcoesCalculo
        {
            opcaoSair,
            opcaoSomar,
            opcaoSubtrair,
            opcaoMultiplicar,
            opcaoDividir
        };
    }
}
