using System;

namespace ConsoleExercicio_2.RegraNegocio
{
    public class Funcionario: IComparable
    {
        public string NomeFuncionario { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(string nomeFuncionario, double salario)
        {
            NomeFuncionario = nomeFuncionario;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Funcionário: {NomeFuncionario} - Salário: {Salario:C2}";
        }

        public bool PossuiMaiorSalario(Funcionario funcionario)
        {
            return (funcionario != null) && (this.Salario > funcionario.Salario);
        }

        public bool PossuiMenorSalario(Funcionario funcionario)
        {
            return (funcionario != null) && (this.Salario > funcionario.Salario);
        }

        /// <summary>
        /// Retorna se o sálario do funcionário é maior do que do funcionário passado por paraâmetro
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// 0 - Salários iguais
        /// 1 - Funcionario tem salário maior
        /// -1 - Funcionário tem salário menor
        /// </returns>
        public int CompareTo(object obj)
        {
            var funcionario = (Funcionario)obj;

            if (funcionario.Salario == Salario)
                return 0;

            return (Salario > funcionario.Salario ? 1 : -1);

        }
    }
}
