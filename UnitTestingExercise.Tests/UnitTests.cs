using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(8, 5, 3)]

        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(5, 8, 40)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(28, 7, 4)]
        public void Divide(int dividend, int divisor, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(dividend, divisor);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAdd()
        {
            ////Arrange
            //var test = new UnitTestMethods();
            ////Act
            //var result = test.IsEven();
            ////Assert
            //Assert.Equal(true, actual);

            var unitTest = new UnitTestMethods();
            var actual = unitTest.CanAdd(2, 4);
            Assert.Equal(6, actual);
        }

        [Fact]
        public void NameIsNotNull()
        {
            var unitTest = new UnitTestMethods("Chris");
            bool actual = unitTest.Name != null;
            Assert.True(actual, "The name property should not be null.");
        }
    }
}
