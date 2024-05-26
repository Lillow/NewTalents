using NewTalents;
using System;
using Xunit;

namespace TesteNewTalents
{
    public class TesteCalculadora
    {

        Calculadora _calc;

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1, int num2, int res )
        {
            _calc = new Calculadora();

            int resultado = _calc.Somar(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int num1, int num2, int res)
        {
            _calc = new Calculadora();

            int resultado = _calc.Subtrair(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(5, 5, 25)]
        public void TesteMutiplicar(int num1, int num2, int res)
        {
            _calc = new Calculadora();

            int resultado = _calc.Mutiplicar(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int num1, int num2, int res)
        {
            _calc = new Calculadora();

            int resultado = _calc.Dividir(num1, num2);

            Assert.Equal(res, resultado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            _calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc = new Calculadora();

            _calc.Somar(1,2);
            _calc.Somar(2, 2);
            _calc.Somar(3, 4);
            _calc.Somar(5, 22);

            Assert.NotEmpty(_calc.GetHistorico());
            Assert.Equal(3, _calc.GetHistorico().Count);
        }
    }
}
