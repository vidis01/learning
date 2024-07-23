using Learning.Classes;

namespace Tests.Learning
{
    public class CalculatorTest
    {
        private Calculator calculator;
        public CalculatorTest()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(3.5, 4, 7.5)]
        [InlineData(3.57, 4.7, 8.27)]
        [InlineData(3.5, 4.9, 8.4)]
        public void TestSuma(double a, double b, double expectedResult)
        {
            var actualRezul = calculator.Suma(a, b);

            Assert.Equal(expectedResult, actualRezul);
        }
    }
}