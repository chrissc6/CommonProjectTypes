using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTestMiniProject.Tests
{
    public class BasicMathOperationsTests
    {
        [Fact]
        public void AdditionTest()
        {
            //Arrange
            BasicMathOperations add = new BasicMathOperations();
            double expected = 2;
            double expected2 = 3;

            //Act
            double actual = add.Addition(1, 1);
            double actual2 = add.Addition(1, 2);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void SubtractionTest()
        {
            //Arrange
            BasicMathOperations add = new BasicMathOperations();
            double expected = 2;
            double expected2 = 3;

            //Act
            double actual = add.Subtraction(3, 1);
            double actual2 = add.Subtraction(5, 2);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void MultiplicationTest()
        {
            //Arrange
            BasicMathOperations add = new BasicMathOperations();
            double expected = 2;
            double expected2 = 3;

            //Act
            double actual = add.Multiplication(2, 1);
            double actual2 = add.Multiplication(1, 3);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void DivisionTest()
        {
            //Arrange
            BasicMathOperations add = new BasicMathOperations();
            double expected = 2;
            double expected2 = 3;

            //Act
            double actual = add.Division(4, 2);
            double actual2 = add.Division(6, 2);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(10, 10, 20)]
        [InlineData(50, 50, 100)]
        [InlineData(999, 1, 1000)]
        public void AdditionShouldReturnExpectedValue(
            double x,
            double y,
            double expected)
        {
            //Arrange
            BasicMathOperations bm = new BasicMathOperations();

            //Act
            double actual = bm.Addition(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(10, 9, 1)]
        [InlineData(50, 40, 10)]
        [InlineData(1001, 1, 1000)]
        public void SubtractionShouldReturnExpectedValue(
            double x,
            double y,
            double expected)
        {
            //Arrange
            BasicMathOperations bm = new BasicMathOperations();

            //Act
            double actual = bm.Subtraction(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        [InlineData(5, 5, 25)]
        [InlineData(10, 10, 100)]
        public void MultiplicationShouldReturnExpectedValue(
            double x,
            double y,
            double expected)
        {
            //Arrange
            BasicMathOperations bm = new BasicMathOperations();

            //Act
            double actual = bm.Multiplication(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(3, 3, 1)]
        [InlineData(25, 5, 5)]
        [InlineData(10, 0, 0)]
        public void DivisionShouldReturnExpectedValue(
            double x,
            double y,
            double expected)
        {
            //Arrange
            BasicMathOperations bm = new BasicMathOperations();

            //Act
            double actual = bm.Division(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
