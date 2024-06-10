namespace Geometry
{
    public class Square : Shape
    {

        protected double _side_a;

        // Constructor
        public Square(double side)
        {
            _side_a = side;
        }

        // Property with get and set accessors
        public double Side
        {
            get { return _side_a; }
            set { _side_a = value; }
        }

        // Method to calculate the perimeter
        public override double CalculatePerimeter()
        {
            return _side_a * 4;
        }
        // Method to calculate the area
        public override double CalculateArea()
        {
            return _side_a * _side_a;
        }
    }
}
