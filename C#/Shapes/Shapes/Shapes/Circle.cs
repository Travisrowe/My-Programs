//Circle.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Circle inherits from TwoDShape
namespace Shapes
{
    /*Code from Catherine Stringfellow*/
    public class Circle : TwoDShape
    {
        Point center;

        private double radius; // Circle radius

        // default constructor
        public Circle()
        {
            // implicit call to Point2 constructor occurs here
        }

        // constructor
        public Circle(int xPoint, int yPoint, double radiusValue)
        {
            center = new Point(xPoint, yPoint);
            Radius = radiusValue;
        }

        // property Radius
        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                // ensure non-negative radius value
                if (value >= 0)
                    radius = value;
            }
        }

        // calculate Circle diameter
        public double Diameter()
        {
            return Radius * 2;
        }

        // calculate Circle circumference
        public override double Perimeter()
        {
            return Math.PI * Diameter();
        }

        // calculate Circle area
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // return string representation of Circle object
        public override string ToString()
        {
            return "Center = " + center + "; Radius = " + Radius;
        }

        // override property Name from class Shape
        public override string Name
        {
            get
            {
                return "Circle";
            }
        }
    } // end class Circle
}
