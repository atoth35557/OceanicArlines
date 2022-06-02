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
            mock.Setup(x => x.Add(It,1)).Returns
                (6);
            int number1 = 1;
            int number2 = 4;
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