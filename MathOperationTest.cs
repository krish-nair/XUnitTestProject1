using System;
using Xunit;

namespace XUnitTestProject1
{
    public class MathOperationTest
    {
        [Fact]
        public void TaskAddTwoNumber()
        {
            //arrange
            var num1 = 2.9;
            var num2 = 3.1;
            var expected_value = 6;

            //action
            var sum = MathOperation.Add(num1, num2);

            //Assert
            Assert.Equal(expected_value, sum, 1);
        }

        [Fact]
        public void TaskSubstractTwoNumber()
        {
            var num1 = 5.8;
            var num2 = 2.3;
            var expectedValue = 3.5;

            var sub = MathOperation.Substract(num1, num2);

            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact]
        public void TaskMultiplyTwoNumber()
        {
            var num1 = 5.8;
            var num2 = 2.3;
            var expectedValue = 13.34;

            var multi = MathOperation.Multiply(num1, num2);

            Assert.Equal(expectedValue, multi, 2);
        }

        [Fact]
        public void TaskDivideTwoNumber()
        {
            var num1 = 50.8;
            var num2 = 2.4;
            var expectedValue = 21.19;

            var divide = MathOperation.Divide(num1, num2);

            Assert.Equal(expectedValue, divide, 1);
        }
    }
}
