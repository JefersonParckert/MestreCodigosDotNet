using System;
using ExercicioPOO_2;
using Xunit;

namespace ExercicioPOO_2_XUnitTests
{
    public class PessoaXUnitTests
    {
        [Theory]
        [InlineData("Jeferson", 1.8, 1984, 3, 2, 36)]
        [InlineData("Vanessa", 1.68, 1984, 10, 6, 35)]
        [InlineData("Bianca", 1.1, 2015, 10, 3, 4)]
        public void PegarIdadePessoa_PessoaComDadosValidos_DeveRetoranarIdateCorretamente(
            string nome,
            double altura,
            int anoNascimento,
            int mesNascimento,
            int diaNascimento,
            int idadeEsperada)
        {
            // Arrange
            var dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);
            var datacorrente = new DateTime(2020, 08, 31);
            var pessoa = new Pessoa(nome, dataNascimento, altura);

            // Act
            var idade = pessoa.PegarIdadePessoa(datacorrente);

            // Assert
            Assert.Equal(idadeEsperada, idade);
        }

        [Fact]
        public void PropertyAltura_AlturaMenorZero_DeveRetornarExcecao()
        {
            // Arrange
            var pessoa = new Pessoa();

            // Act, Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { pessoa.Altura = -1; }); ;
        }

        [Fact]
        public void PropertyDataNasimento_DataCorrente_DeveRetornarExcecao()
        {
            // Arrange
            var pessoa = new Pessoa();

            // Act, Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { pessoa.DataNascimento = DateTime.Now.AddDays(1); }); ;
        }
    }
}
