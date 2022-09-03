using Square.Exceptions;

namespace Square.Models
{
    public class Circle : Figure
    {
        public Circle(double r)
        {
            if (r < 0) throw new RadiusInvalidException("Can not be less than zero.");

            R = r;
        }

        public double R { get; }

        public override double Square()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
