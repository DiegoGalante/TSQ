using Xunit;

namespace TSQ.Tests
{
    public class ProgramTests
    {
        [Theory(DisplayName = "Soma dois inteiros")]
        [InlineData(10, 10, 20)]
        public void Program_Somar(int a, int b, int resultado)
        {
            var res = Program.Somar(a, b);

            Assert.Equal(res, resultado);
        }

        [Theory(DisplayName = "Subtrai dois inteiros")]
        [InlineData(30, 20, 10)]
        [InlineData(10, 10, 0)]
        public void Program_Subtrair(int a, int b, int resultado)
        {
            var res = Program.Subtrair(a, b);

            Assert.Equal(res, resultado);
        }

        [Theory(DisplayName = "Multiplica dois inteiros")]
        [InlineData(10, 10, 100)]
        public void Program_Multiplicar(int a, int b, int resultado)
        {
            var res = Program.Multiplicar(a, b);

            Assert.Equal(res, resultado);
        }

        [Theory(DisplayName = "Escreve o texto passado por parametro")]
        [InlineData("abc", "abc")]
        public void Program_RetornarString(string texto, string resultado)
        {
            var res = Program.RetornarString(texto);

            Assert.Equal(res, resultado);
        }
    }
}
