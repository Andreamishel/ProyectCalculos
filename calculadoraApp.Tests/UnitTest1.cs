using Xunit;
namespace calculadoraApp.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Sumar_DosNumeros_VerificaSumaCorrecta()
    {
        var calc = new calculadoraApp.calculadora();
        var resultado = calc.Sumar(2, 3);
        Assert.Equal(5, resultado);
    }
}
