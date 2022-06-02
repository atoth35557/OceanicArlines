using Moq;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mock = new Mock<DummyService>();
            mock.Setup(x => x.Add(2,3)).Returns
                (5);
            int number1 = 2;
            int number2 = 3;
            var calculator = new Calculator(mock.Object);


            int result = calculator
                .Calculate
                (number1, number2);

            Assert.Equal(5, result);
        }
        
    }
    public class Calculator
    {
        private readonly DummyService dummyService;

        public Calculator(DummyService dummyService)
        {
            this.dummyService = dummyService;
        }
        public int Calculate(int num1, int num2)
        {
            return dummyService.Add(num1, num2);
        }
    }
    public interface DummyService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}