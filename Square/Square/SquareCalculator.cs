using Square.Interfaces;
using Square.Models;

namespace Square
{
    public class SquareCalculator : ISquareCalculator
    {
        public double GetSquare(Figure figure)
        {
            return figure.Square();
        }
    }
}
