using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }
}
