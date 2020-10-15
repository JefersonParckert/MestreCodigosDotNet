using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPOO_1._3_Abstracao
{
    public class Livro : Produto
    {
        public int AnoLancamento { get; set; }
        public string Autor { get; set; }
        public int QtdePaginas { get; set; }

        public Livro(int id, string nome, decimal valor, int anoLancamento, string autor, int qtdePaginas)
            : base(id, nome, valor)
        {
            AnoLancamento = anoLancamento;
            Autor = autor;
            QtdePaginas = qtdePaginas;
        }

        public override string DescricaoProduto()
        {
            return $"Livro com {QtdePaginas} paginas, lançado em {AnoLancamento} pelo autor {Autor}!";
        }
    }
}
