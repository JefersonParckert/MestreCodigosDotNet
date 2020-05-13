using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_4.RegraNegocio
{
    public class Aluno
    {
        private List<float> _notas;
        public string Nome { get; private set; }
        public float Media 
        {
            get {
                return _notas.Average();
            }
        }

        public Aluno(string nome, float[] notas)
        {
            if (!TestarNotasValidas(notas))
                throw new ArgumentException("As notas do Aluno devem ser informadas");

            Nome = nome;
            _notas = notas.ToList<float>();
        }

        private bool TestarNotasValidas(float[] notas)
        {
            return (notas != null) && (notas.Length > 0);
        }

        public override string ToString()
        {
            return $"Aluno: {Nome} - Média: {Media:N2}";
        }
    }
}
