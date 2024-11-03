using NewTalents;

namespace TestNewTalents;

public class CalculadoraTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(52, 84, 136)]
    public void Somar(int number1, int number2, int expected)
    {
        Calculadora calc = new();

        int result = calc.Somar(number1, number2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    [InlineData(52, 84, -32)]
    public void Subtrair(int number1, int number2, int expected)
    {
        Calculadora calc = new();

        int result = calc.Subtrair(number1, number2);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    [InlineData(52, 84, 4368)]
    public void Multiplicar(int number1, int number2, int expected)
    {
        Calculadora calc = new();

        int result = calc.Multiplicar(number1, number2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    [InlineData(420, 84, 5)]
    public void Dividir(int number1, int number2, int expected)
    {
        Calculadora calc = new();

        int result = calc.Dividir(number1, number2);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = new();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = new();

        calc.Somar(1, 2);
        calc.Somar(2, 44);
        calc.Somar(2, 25);
        calc.Somar(4, 22);
        var historico = calc.Historico();

        Assert.NotEmpty(historico);
        Assert.Equal(3, historico.Count);
    }
}