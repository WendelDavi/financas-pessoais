using Financas.Domain.Entities;
using Financas.Domain.Enums;

namespace Financas.Tests.Entities;

public class ContaTests
{

    // Teste conta com dados válidos
    [Fact]
    public void CriarConta_ComDadosValidos_DeveCriarContaAtiva()
    {
        // Prepara os dados necessários
        string nome = "Conta Principal";
        TipoConta tipo = TipoConta.Corrente;
        decimal saldoInicial = 250m;

        // Executa o comportamento testado
        var conta = new Conta(nome, tipo, saldoInicial);

        // Verifica o resultado esperado
        Assert.NotEqual(Guid.Empty, conta.Id);
        Assert.Equal(nome, conta.Nome);
        Assert.Equal(tipo, conta.Tipo);
        Assert.Equal(saldoInicial, conta.SaldoInicial);
        Assert.True(conta.Ativa);
    }

    // Teste conta com nome vazio
    [Fact]
    public void CriarConta_ComNomeVazio_DeveLancarExcecao()
    {
        // Arrange
        string nome = "";

        // Act
        Action acao = () => new Conta(
                nome,
                TipoConta.Corrente,
                0m
        );

        // Assert

        Assert.Throws<ArgumentException>(acao);
    }

    // Teste nome contendo apenas espaço
    [Fact]
    public void CriarConta_ComNomeEmBranco_DeveLancarExcecao()
    {
        Assert.Throws<ArgumentException>(() =>
                new Conta("   ", TipoConta.Corrente, 0m)
        );
    }

    // Teste saldo inicial negativo
    [Fact]
    public void CriarConta_ComSaldoNegativo_DevePermitir()
    {
        // Arrange
        decimal saldoInicial = -150m;

        // Act
        var conta = new Conta("Conta Principal", TipoConta.Corrente, saldoInicial);

        // Assert
        Assert.Equal(saldoInicial, conta.SaldoInicial);
    }
    // Teste tipo de conta inválido
    [Fact]
    public void CriarConta_ComTipoInvalido_DeveLancarExcecao()
    {
        var tipoInvalido = (TipoConta)999;

        Assert.Throws<ArgumentOutOfRangeException>(() =>
                new Conta("Conta Principal", tipoInvalido, 0m)
        );
    }

    [Fact]
    public void AlterarNome_ComNomeValido_DeveAtualizarNome()
    {
        // Arrange
        var conta = new Conta("Conta Principal", TipoConta.Corrente, 100m);

        // Act
        conta.AlterarNome("Nubank");

        // Assert
        Assert.Equal("Nubank", conta.Nome);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData(null)]
    public void AlterarNome_ComNomeInvalido_DeveLancarExcecao(string? novoNome)
    {
        // Arrange
        var conta = new Conta("Conta Principal", TipoConta.Corrente, 100m);

        // Act e Assert
        Assert.Throws<ArgumentException>(() =>
                conta.AlterarNome(novoNome!)
                );

        Assert.Equal("Conta Principal", conta.Nome);
    }

    [Fact]
    public void AlterarNome_ComEspacos_DeveNormalizarNome()
    {
        // Arrange
        var conta = new Conta("Conta Principal", TipoConta.Corrente, 100m);

        // Act
        conta.AlterarNome("  Nubank  ");

        // Assert 
        Assert.Equal("Nubank", conta.Nome);
    }
}