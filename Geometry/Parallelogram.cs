using System;

namespace Geometry
{
    internal class Parallelogram : Square
    {
        private double _side_b;

        public Parallelogram(float side_a, float side_b) : base(side_a)
        {
            _side_b = side_b;
        }

        public double Side_b
        {
            get { return _side_b; }
            set { _side_b = value; }
        }

        public override double CalculatePerimeter()
        {
            return (_side_a + _side_b) * 2;
        }
        public override double CalculateArea()
        {
            double h = _side_b * Math.Sin(90);
            return h * _side_a;
        }
    }
}
