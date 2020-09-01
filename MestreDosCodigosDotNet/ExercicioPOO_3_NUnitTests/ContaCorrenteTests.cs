using System;
using ExercicioPOO_3.Dominio;
using NUnit.Framework;

namespace ExercicioPOO_3_NUnitTests
{
    public class ContaCorrenteTests
    {
        private const Double SALDO_INICIAL = 100.0;
        private const Double TAXA_OPERACAO = 0.33;
        private const int NUMERO_CONTA = 1;


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ContaCorrente_Sacar_DeveDecremetarSaldo()
        {
            // Arrange
            var valorsaque = 90.0;
            var saldoAtualizado = Math.Round(SALDO_INICIAL - TAXA_OPERACAO - valorsaque, 2);
            var contaCorrente = PegarContaCorrente();

            // Act
            contaCorrente.Sacar(valorsaque);

            // Assert
            Assert.AreEqual(saldoAtualizado, contaCorrente.Saldo);
        }

        [Test]
        public void ContaCorrente_Sacar_NaoDeveDecremetarSaldo()
        {
            // Arrange
            var valorsaque = 99.78;
            var contaCorrente = PegarContaCorrente();

            // Act
            contaCorrente.Sacar(valorsaque);

            // Assert
            Assert.AreEqual(SALDO_INICIAL, contaCorrente.Saldo);
        }

        [Test]
        public void ContaCorrente_Depositar_DeveIncremetarSaldo()
        {
            // Arrange
            var valorDeposito = 10;
            var saldoAtualizado = SALDO_INICIAL - TAXA_OPERACAO + valorDeposito;
            var contaCorrente = PegarContaCorrente();

            // Act
            contaCorrente.Depositar(valorDeposito);

            // Assert
            Assert.AreEqual(saldoAtualizado, contaCorrente.Saldo);
        }

        [Test]
        public void ContaCorrente_Depositar_NaoDeveIncremetarSaldo()
        {
            // Arrange
            var contaCorrente = PegarContaCorrente();

            // Act
            contaCorrente.Depositar(-1);

            // Assert
            Assert.AreEqual(SALDO_INICIAL, contaCorrente.Saldo);
        }

        private ContaCorrente PegarContaCorrente()
        {
            return new ContaCorrente(NUMERO_CONTA, SALDO_INICIAL, TAXA_OPERACAO);
        }
    }
}