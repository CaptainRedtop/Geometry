using System;

namespace Geometry
{
    internal class Trapezoid : Square
    {
        private double _side_b;
        private double _side_c;
        private double _side_d;

        public Trapezoid(double side_a, double side_b, double side_c, double side_d) : base(side_a)
        {
            _side_b = side_b;
            _side_c = side_c;
            _side_d = side_d;
        }

        public double SideB
        {
            get { return _side_a; }
            set { _side_a = value; }
        }
        public double SideC
        {
            get { return _side_a; }
            set { _side_a = value; }
        }
        public double SideD
        {
            get { return _side_a; }
            set { _side_a = value; }
        }

        public override double CalculatePerimeter()
        {
            return _side_a + _side_b + _side_c + _side_d;
        }
        public override double CalculateArea()
        {
            double s = (_side_a + _side_b - _side_c + _side_d) / 2;
            double h = 2 / (_side_a - _side_c) * Math.Sqrt(s * (s - _side_a + _side_c) - (s - _side_b) * (s - _side_d));
            return 0.5 * (_side_a + _side_c) * h;
        }
    }
}
