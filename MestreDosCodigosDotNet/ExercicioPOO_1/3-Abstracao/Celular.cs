namespace ExercicioPOO_1._3_Abstracao
{
    public class Celular : Produto
    {
        public string Marca { get; set; }
        public decimal TamanhoTela { get; set; }
        public int CapacidadeArmazenamento { get; set; }
        public string Cor { get; set; }

        public Celular(int id, string nome, decimal valor, string marca, decimal tamanhoTela, int capacidadeArmazenamento, string cor)
            : base(id, nome, valor)
        {
            Marca = marca;
            TamanhoTela = tamanhoTela;
            CapacidadeArmazenamento = capacidadeArmazenamento;
            Cor = cor;
        }

        public override string DescricaoProduto()
        {
            return $"Celular {Marca} na cor {Cor} com tela de {TamanhoTela} polegadas e com {CapacidadeArmazenamento}GB de Armazenamento";
        }
    }
}
