using System;

namespace Geometry
{
    internal class RightAngledTriangle : Shape
    {
        private double a; // katete 1
        private double b; // katete 2
        private double c; // hypotenuse

        public RightAngledTriangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.c = Math.Sqrt(a * a + b * b); // Pythagoras
        }

        public override double CalculateArea()
        {

            return 0.5 * a * b;
        }

        public override double CalculatePerimeter()
        {

            return a + b + c;
        }
    }
}
