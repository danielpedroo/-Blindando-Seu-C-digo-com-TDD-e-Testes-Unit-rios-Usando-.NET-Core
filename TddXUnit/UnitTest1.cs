using TDD.Src.Entities;

namespace TddXUnit
{
    public class UnitTest1
    {

        public Calculator constructClass()
        {
            string data = "03/06/2024";
            Calculator calculator = new Calculator(data);

            return calculator;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void Sum(int value1, int value2, int totalvalue)
        {

            Calculator calc = constructClass();

            int resultSum = calc.Sum(value1, value2);

            //Tdd SUM
            Assert.Equal(totalvalue, resultSum);

        }


        [Theory]
        [InlineData(200, 100, 100)]
        [InlineData(1500, 100, 1400)]
        public void Subtract(int value1, int value2, int totalvalue)
        {

            Calculator calc = constructClass();

            int resultSum = calc.Subtract(value1, value2);

            //Tdd Subtract
            Assert.Equal(totalvalue, resultSum);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(10, 10, 100)]
        public void Multiply(int value1, int value2, int totalvalue)
        {

            Calculator calc = constructClass();

            int resultSum = calc.Multiply(value1, value2);

            //Tdd Multiply
            Assert.Equal(totalvalue, resultSum);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(70, 2, 35)]
        public void ToDivide(int value1, int value2, int totalvalue)
        {

            Calculator calc = constructClass();

            int resultSum = calc.ToDivide(value1, value2);

            //Tdd To Divide
            Assert.Equal(totalvalue, resultSum);

        }

        [Fact]
        public void TestToDividePerZero()
        {

            Calculator calc = constructClass();

            Assert.Throws<DivideByZeroException>(() => calc.ToDivide(10,0));

        }

        [Fact]
        public void LogExists()
        {

            Calculator calc = constructClass();

            calc.Sum(5, 1);
            calc.Sum(5, 2);
            calc.Sum(5, 3);
            calc.Sum(5, 4);

            var Log = calc.logCaculator();

            //Validado de Log Vazio
            Assert.NotEmpty(Log);

            //Validador de 3 Itens dentro do log
            Assert.Equal(3, Log.Count);
        }
    }
}