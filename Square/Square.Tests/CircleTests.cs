using Square.Exceptions;
using Square.Models;
using Xunit;

namespace Square.Tests;

public class CircleTests
{
    [Fact]
    public void Square_Radius3_Answer28()
    {
        //Arrange
        var figure = new Circle(3);
        var calculator = new SquareCalculator();

        //Act
        var square = calculator.GetSquare(figure);

        //Assert
        Assert.Equal(28.274333882308138, square);
    }

    [Fact]
    public void Create_NegativeRadius_RadiusInvalidException()
    {
        //Arrange
        Circle CreateCirceWithNegativeRadius() => new(-1);

        //Assert
        Assert.Throws<RadiusInvalidException>(CreateCirceWithNegativeRadius);
    }
}
