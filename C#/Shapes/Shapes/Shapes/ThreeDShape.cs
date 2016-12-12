//ThreeDShape.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//An abstract class for 3D shapes. Inherits from Point
namespace Shapes
{
    public abstract class ThreeDShape : Point
    {
        Point point;

        public ThreeDShape()
        {
            //implicit call to constructor
        }

        public ThreeDShape(int xPoint, int yPoint, int zPoint)
        {
            point = new Point(xPoint, yPoint, zPoint);
        }

        //virtual method for Volume
        public virtual double Volume()
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
