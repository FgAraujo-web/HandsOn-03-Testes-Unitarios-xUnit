
using TestesUnitariosHandsOnDemo.Core;
using Xunit;

namespace TestesUnitariosHandsOnDemo.Tests;

public class CalculadoraDescontosTests
{
    [Fact]
    public void CalcularSubtotal_ValoresValidos_RetornaSubtotalCorreto()
    {
        // Arrange - Preparar os dados
        var calculadora = new CalculadoraDescontos();
        decimal precoUnitario = 50m;
        int quantidade = 3;

        // Act - Executar o método
        decimal resultado = calculadora.CalcularSubtotal(
            precoUnitario, quantidade);

        // Assert - Verificar o resultado
        Assert.Equal(150m, resultado);
    }


    [Theory]
    [InlineData(50, 3, 150)]
    [InlineData(20, 5, 100)]
    [InlineData(15, 2, 30)]
    [InlineData(100, 1, 100)]
    public void CalcularSubtotal_DiferentesValores_RetornaResultadoCorreto(
        decimal precoUnitario,
        int quantidade,
        decimal subtotalEsperado)
    {
        // Arrange
        var calculadora = new CalculadoraDescontos();

        // Act
        decimal resultado = calculadora.CalcularSubtotal(
            precoUnitario, quantidade);

        // Assert
        Assert.Equal(subtotalEsperado, resultado);
    }


    [Theory]
    [InlineData(-10, 2)]
    [InlineData(50, 0)]
    [InlineData(50, -1)]
    public void CalcularSubtotal_ValoresInvalidos_LancaArgumentException(
        decimal precoUnitario,
        int quantidade)
    {
        // Arrange
        var calculadora = new CalculadoraDescontos();

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            calculadora.CalcularSubtotal(precoUnitario, quantidade));
    }



    [Theory]
    [InlineData(100, 10, 10)]
    [InlineData(200, 25, 50)]
    [InlineData(150, 0, 0)]
    [InlineData(100, 100, 100)]
    [InlineData(80, 50, 40)]
    public void CalcularDesconto_ValoresValidos_RetornaDescontoCorreto(
        decimal subtotal,
        decimal percentagem,
        decimal descontoEsperado)
    {
        // Arrange
        var calculadora = new CalculadoraDescontos();

        // Act
        decimal resultado = calculadora.CalcularDesconto(
            subtotal, percentagem);

        // Assert
        Assert.Equal(descontoEsperado, resultado);
    }


    [Theory]
    [InlineData(100, -10)]
    [InlineData(200, 110)]
    [InlineData(150, -1)]
    [InlineData(-50, 20)]
    public void CalcularDesconto_ValoresInvalidos_LancaArgumentException(
        decimal subtotal,
        decimal percentagem)
    {
        // Arrange
        var calculadora = new CalculadoraDescontos();

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            calculadora.CalcularDesconto(subtotal, percentagem));
    }


    [Theory]
    [InlineData(150, 15, 135)]
    [InlineData(200, 50, 150)]
    [InlineData(100, 0, 100)]
    [InlineData(100, 100, 0)]
    [InlineData(80, 20, 60)]
    public void CalcularTotal_ValoresValidos_RetornaTotalCorreto(
        decimal subtotal,
        decimal desconto,
        decimal totalEsperado)
    {
        // Arrange
        var calculadora = new CalculadoraDescontos();

        // Act
        decimal resultado = calculadora.CalcularTotal(
            subtotal, desconto);

        // Assert
        Assert.Equal(totalEsperado, resultado);
    }


    [Theory]
    [InlineData(-100, 10)]
    [InlineData(100, -10)]
    [InlineData(100, 150)]
    [InlineData(-50, -10)]
    public void CalcularTotal_ValoresInvalidos_LancaArgumentException(
        decimal subtotal,
        decimal desconto)
    {
        // Arrange
        var calculadora = new CalculadoraDescontos();

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            calculadora.CalcularTotal(subtotal, desconto));
    }


}
