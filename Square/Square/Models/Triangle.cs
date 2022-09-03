using Square.Exceptions;

namespace Square.Models
{
    public class Triangle : Figure
    {
        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new TriangleInvalidException("Sum of two sides must be greater than the third side.");
            }


            A = a;
            B = b;
            C = c;
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public override double Square()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular()
        {
            const double tolerance = 0.0001;
            return Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) < tolerance ||
                   Math.Abs(Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) < tolerance ||
                   Math.Abs(Math.Pow(B, 2) + Math.Pow(C, 2) - Math.Pow(A, 2)) < tolerance;
        }
    }
}
