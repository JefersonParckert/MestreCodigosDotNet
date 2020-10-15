using System;
using ExercicioPOO_3.Dominio;
using Xunit;

namespace ExercicioPOO_3_XUnitTests
{
    public class ContaEspecialTests
    {
        private const decimal SALDO_INICIAL = 100m;
        private const decimal LIMITE = 200m;
        private const int NUMERO_CONTA = 1;

        [Fact]
        public void ContaEspecial_Sacar_DeveAtualizarSaldo()
        {
            // Arrange
            var valorsaque = 90m;
            var saldoAtualizado = Math.Round(SALDO_INICIAL - valorsaque, 2);
            var contaEspecial = PegarContaEspecial();

            // Act
            contaEspecial.Sacar(valorsaque);

            // Assert
            Assert.Equal(saldoAtualizado, contaEspecial.Saldo);
        }

        [Fact]
        public void ContaEspecial_Sacar_NaoDeveAtualizarSaldo()
        {
            // Arrange
            var valorsaque = 350m;
            var contaEspecial = PegarContaEspecial();

            // Act
            contaEspecial.Sacar(valorsaque);

            // Assert
            Assert.Equal(SALDO_INICIAL, contaEspecial.Saldo);
        }

        [Fact]
        public void ContaEspecial_Depositar_NaoDeveAtualizarSaldo()
        {
            // Arrange
            var contaEspecial = PegarContaEspecial();

            // Act
            contaEspecial.Depositar(-1m);

            // Assert
            Assert.Equal(SALDO_INICIAL, contaEspecial.Saldo);
        }

        [Fact]
        public void ContaEspecial_Depositar_DeveAtualizarSaldo()
        {
            // Arrange
            var valorDeposito = 100m;
            var saldoAtualizado = Math.Round(SALDO_INICIAL + valorDeposito, 2);
            var contaEspecial = PegarContaEspecial();

            // Act
            contaEspecial.Depositar(valorDeposito);

            // Assert
            Assert.Equal(saldoAtualizado, contaEspecial.Saldo);
        }

        private static ContaEspecial PegarContaEspecial()
        {
            return new ContaEspecial(NUMERO_CONTA, SALDO_INICIAL, LIMITE);
        }
    }
}
