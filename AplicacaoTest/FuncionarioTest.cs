using NUnit.Framework;
using Aplicacao;

namespace AplicacaoTest
{
    class FuncionarioTest
    {
        [Test]
        public void Funcionario_Apresentacao_Deve_Funcionar_Como_Esperado()
        {
            // arrange
            var sut = new Funcionario("Maria", "Programadora", 100000);
            var esperado = "Olá! Meu nome é Maria e eu trabalho como Programadora.";

            // act
            string obtido = sut.Apresentar();

            // assert
            Assert.AreEqual(esperado, obtido);
        }

        [Test]
        public void Funcionario_Dar_Aumento_De_Dez_Porcento_Deve_Aumentar_Salario_De_100_Para_110()
        {
            // arrange
            var percentual = 10;
            var sut = new Funcionario("Bob", "Tester", 100);
            var esperado = 110;

            // act
            sut.DarAumento(percentual);
            var novoSalario = sut.Salario;

            // assert
            Assert.AreEqual(esperado, novoSalario);
        }

        [Test]
        public void Funcionario_Tentativa_De_Dar_Aumento_Negativo_Nao_Deve_Fazer_Efeito()
        {
            // arrange
            var percentual = -10;
            var salario = 100;
            var sut = new Funcionario("Bob", "Tester", 100);
            var esperado = salario;

            // act
            sut.DarAumento(percentual);
            var obtido = sut.Salario;

            // assert
            Assert.AreEqual(esperado, obtido);
        }
    }
}
