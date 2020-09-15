using System.Collections;

namespace ExercicioPOO_1
{
    public class Empresa : IEnumerable
    {
        private readonly Funcionario[] _funcionarios;

        public Empresa(Funcionario[] funcionarios)
        {
            _funcionarios = new Funcionario[funcionarios.Length];

            for (var i = 0; i < funcionarios.Length; i++)
            {
                _funcionarios[i] = funcionarios[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _funcionarios.GetEnumerator();
        }
    }
}