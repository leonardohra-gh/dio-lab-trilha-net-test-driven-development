using NewTalents;

namespace TestNewTalents;

public class CalculadoraTest
{
    private Calculadora calculadora = new();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    [InlineData(52, 84, 136)]
    public void Somar(int number1, int number2, int expected)
    {
        int result = calculadora.Somar(number1, number2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    [InlineData(52, 84, -32)]
    public void Subtrair(int number1, int number2, int expected)
    {
        int result = calculadora.Subtrair(number1, number2);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    [InlineData(52, 84, 4368)]
    public void Multiplicar(int number1, int number2, int expected)
    {
        int result = calculadora.Multiplicar(number1, number2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    [InlineData(420, 84, 5)]
    public void Dividir(int number1, int number2, int expected)
    {
        int result = calculadora.Dividir(number1, number2);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        calculadora = new();
        
        calculadora.Somar(1, 2);
        calculadora.Somar(2, 44);
        calculadora.Somar(2, 25);
        calculadora.Somar(4, 22);
        var historico = calculadora.Historico();

        Assert.NotEmpty(historico);
        Assert.Equal(3, historico.Count);
    }
}