using ExercicioPOO_1._3_Abstracao;
using System;

namespace ExercicioPOO_1
{
    /*
     * A ideia da Abstração na orientação a objetos é oferecer um conjunto de estados e comportamentos que abstraem uma certa especialização
     * ou seja, para um detrminado grupo de objetos devemos considerar as qualidades e comportamentos independentes do objeto, 
     * isolando seus atributos considerando apenas o que eles tem em comun. 
     * 
     * No exemplo abaixo temos a classe abstrata produto que possui os atributos (id, nome e Valor) que são comuns para os produtos Livro e celular, 
     * alem disto possui também um método abstrato que retorna a descrição do produto e que deve ser implementado pelas classes concretas Celular e Livro
     * desta forma criamos a classe concreta livro que herda de produto, ou seja ela possui os mesmos atributos da classe produto
     * porem possui os atributos especificos de livro (Ano do lançamento, autor e Qtde de Paginas) e implementa a abstração de descrição do produto
     * a classe celular também herda de produto e possui os seguintes atributos (marca, Tamanho da tela, Armazenamento e cor)
     */
   

    //to do: melhorar

    public static class Abstracao
    {
        public static void Executar()
        {
            Console.WriteLine("========== Abstração ===========");
            
            Produto livro = new Livro(1, "O Senhor dos Anéis: A Sociedade do Anel", 100m, 2000, "J. R. R. Tolkien", 450);
            Console.WriteLine($"Livro: {livro.Nome} - {livro.DescricaoProduto()}");
            Console.WriteLine();

            Produto celular = new Celular(1, "Moto G8", 1050m, "Motorola", 6.5m, 64, "Azul");
            Console.WriteLine($"Celular: {celular.Nome} - {celular.DescricaoProduto()}");
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}