using ConsoleExercicio_4.RegraNegocio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleExercicio_4
{
    class Program
    {
        public const float MEDIA = 7.0f;
        static void Main(string[] args)
        {
            List<Aluno> listaAlunos = PegarListaAlunos();

            Console.WriteLine($"**  Alunos com média igual ou nuperior a {MEDIA:N1} **");
            var alunosAprovados = PegarAlunosAprovados(listaAlunos, MEDIA);
            foreach (Aluno aluno in alunosAprovados)
                Console.WriteLine(aluno);

            Console.ReadKey();
        }

        private static List<Aluno> PegarAlunosAprovados(List<Aluno> alunos, float mediaEsperda)
        {
            var alunosAprovados = new List<Aluno>();

            alunosAprovados = alunos.Where(a => a.Media >= mediaEsperda).ToList();

            return alunosAprovados;
        }

        private static List<Aluno> PegarListaAlunos()
        {
            List<Aluno> listaAlunos = new List<Aluno>();

            listaAlunos.Add(new Aluno("Rolando Lero", new float[] { 5, 8.5f, 7, 6.5f}));
            listaAlunos.Add(new Aluno("Aldemar Vigário", new float[] { 7, 9.5f, 3.5f, 6.5f }));
            listaAlunos.Add(new Aluno("Armando Volta", new float[] { 10, 8.5f, 7, 2.5f }));
            listaAlunos.Add(new Aluno("Pedro Pedreira", new float[] { 6.5f, 8.5f, 7, 6.5f }));
            listaAlunos.Add(new Aluno("Marina da Glória", new float[] { 9, 8.5f, 7, 9.5f }));
            listaAlunos.Add(new Aluno("Capitu", new float[] { 8, 6.5f, 7.5f, 7 }));
            listaAlunos.Add(new Aluno("Catifunda", new float[] { 4.5f, 8, 5.5f, 7.5f }));

            return listaAlunos;
        }
    }
}
