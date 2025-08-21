using Xunit;
using System;

public class CalculadoraTests
{
    private readonly Calculadora _calc = new Calculadora();

    [Fact]
    public void Soma_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Somar(2, 3);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Subtracao_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Subtrair(10, 4);
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Multiplicacao_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Multiplicar(3, 4);
        Assert.Equal(12, resultado);
    }

    [Fact]
    public void Divisao_DeveRetornarResultadoCorreto()
    {
        double resultado = _calc.Dividir(10, 2);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Divisao_PorZero_DeveLancarExcecao()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(10, 0));
    }
}
