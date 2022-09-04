using Square.Exceptions;
using Square.Models;
using Xunit;

namespace Square.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Square_Sides565_Answer12()
        {
            //Arrange
            var figure = new Triangle(5, 6, 5);
            var calculator = new SquareCalculator();

            //Act
            var square = calculator.GetSquare(figure);

            //Assert
            Assert.Equal(12, square);
        }

        [Fact]
        public void Square_Sides511_ThrowsTriangleInvalidException()
        {
            //Arrange
            Triangle CreateCirceWithNegativeRadius() => new(5, 1, 1);

            //Assert
            Assert.Throws<TriangleInvalidException>(CreateCirceWithNegativeRadius);
        }

        [Fact]
        public void IsRectangular_Sides345_True()
        {
            //Arrange
            var figure = new Triangle(3, 4, 5);

            //Act
            var result = figure.IsRectangular();

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsRectangular_Sides344_False()
        {
            //Arrange
            var figure = new Triangle(3, 4, 4);

            //Act
            var result = figure.IsRectangular();

            //Assert
            Assert.False(result);
        }
    }
}
