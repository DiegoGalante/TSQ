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
    }
}
