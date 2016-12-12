//TwoDShape.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//An abstract class for 2D shapes. Inherits from Point
namespace Shapes
{
    public abstract class TwoDShape : Point
    {
        Point point;
        private string image;
        public TwoDShape()
        {
            // implicit call to constructor
        }
        public TwoDShape(int x, int y)
        {
            point = new Point(x, y);
        }
        //virtual Perimeter method
        public virtual double Perimeter()
        {
            return 0;
        }
        //virtual Area method
        public virtual double Area()
        {
            return 0;
        }
        //ToString method; same as Point here
        public override string ToString()
        {
            return point.ToString();
        }
    }
}
