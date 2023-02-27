using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 20, 30, 60)]
        [InlineData(2, 3, 75, 80)]
        [InlineData(0, -5, 5, 0)]
        [InlineData(0, 0, 0, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator inst = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = inst.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 2, -1)]//Add test data <-------
        [InlineData(10, 10, 0)]
        [InlineData(0, 10, -10)]
        [InlineData(10, 0, 10)]
        [InlineData(5, 3, 2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator inst = new Calculator();

            //Act
            var actual = inst.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 0, 0)]//Add test data <-------
        [InlineData(5, 5, 25)]
        [InlineData(5, 10, 50)]
        [InlineData(12, 12, 144)]
        [InlineData(10, -3, -30)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator inst = new Calculator();

            //Act
            var actual = inst.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(24, 6, 4)]//Add test data <-------
        [InlineData(100, 20, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(15, 3, 5)]
        [InlineData(144, 12, 12)]
        [InlineData(-10, -1, 10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator inst = new Calculator();

            //Act
            var actual = inst.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
