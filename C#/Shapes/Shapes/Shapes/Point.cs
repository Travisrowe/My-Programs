//Point.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Point inherits from abstract class Shape and represents
// an x-y coordinate pair.

namespace Shapes
{
    /*Code from Catherine Stringfellow*/
    public class Point : Shape
    {
        private int x, y, z; // Point coordinates

        // default constructor
        public Point()
        {
            // implicit call to Object constructor occurs here
        }

        // constructor
        public Point(int xValue, int yValue, int zValue = 0)
        {
            X = xValue;
            Y = yValue;
            Z = zValue;
        }

        // propertyX
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value; // no validation needed
            }
        }

        // property Y
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value; // no validation needed
            }
        }
        // property Z
        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value; // no validation needed
            }
        }
        // return string representation of Point object
        public override string ToString()
        {
            if (Z != 0)
                return "[" + X + ", " + Y + ", " + Z + "]";
            return "[" + X + ", " + Y + "]";
        }

        // implement abstract property Name of class Shape
        public override string Name
        {
            get
            {
                return "Point";
            }
        }

    } // end class Point
}
