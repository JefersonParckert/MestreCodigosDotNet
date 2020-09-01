using System;
using ExercicioPOO_2;
using NUnit.Framework;

namespace ExercicioPOO_2_NUnitTests
{
    public class PessoaNunitTests
    {
        [Test]
        [TestCase("Jeferson", 1.8, 1984, 3, 2, 36)]
        [TestCase("Vanessa", 1.68, 1984, 10, 6, 35)]
        [TestCase("Bianca", 1.1, 2015, 10, 3, 4)]
        public void PegarIdadePessoa_PessoaComDadosValidos_DeveRetoranarIdateCorretamente(string nome,
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
            Assert.AreEqual(idadeEsperada, idade);
        }

        [Test]
        public void PropertyAltura_AlturaMenorZero_DeveRetornarExcecao()
        {
            // Arrange
            var pessoa = new Pessoa();

            // Act, Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { pessoa.Altura = -1; }); ;
        }

        [Test]
        public void PropertyDataNasimento_DataCorrente_DeveRetornarExcecao()
        {
            // Arrange
            var pessoa = new Pessoa();

            // Act, Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { pessoa.DataNascimento = DateTime.Now.AddDays(1); }); ;
        }
    }
}
