using System;
using ExercicioPOO_3.Dominio;
using Xunit;

namespace ExercicioPOO_3_XUnitTests
{
    public class ContaEspecialTests
    {
        private const Double SALDO_INICIAL = 100.0;
        private const Double LIMITE = 200;
        private const int NUMERO_CONTA = 1;

        [Fact]
        public void ContaEspecial_Sacar_DeveAtualizarSaldo()
        {
            // Arrange
            var valorsaque = 90.0;
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
            var valorsaque = 350;
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
            contaEspecial.Depositar(-1);

            // Assert
            Assert.Equal(SALDO_INICIAL, contaEspecial.Saldo);
        }

        [Fact]
        public void ContaEspecial_Depositar_DeveAtualizarSaldo()
        {
            // Arrange
            var valorDeposito = 100;
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
