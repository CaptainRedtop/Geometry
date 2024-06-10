namespace Geometry
{
    internal class Rectangle : Square
    {
        private double _side_b;

        public Rectangle(double side_a, double side_b) : base(side_a)
        {
            _side_b = side_b;
        }

        public double SideB
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
            return _side_a * _side_b;

        }
    }
}
