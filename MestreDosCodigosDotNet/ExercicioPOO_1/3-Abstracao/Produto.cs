
namespace ExercicioPOO_1._3_Abstracao
{
    public abstract class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        protected Produto(int id, string nome, decimal valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public abstract string DescricaoProduto();
    }
}
