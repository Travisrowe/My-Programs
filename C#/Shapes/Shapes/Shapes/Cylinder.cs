//Cylinder.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cylinder inherits from Sphere
namespace Shapes
{
    public class Cylinder : Sphere
    {
        private double height; // Cylinder height

        // default constructor
        public Cylinder()
        {
            // implicit call to Circle constructor occurs here
        }

        // constructor
        public Cylinder(int xValue, int yValue, int zValue, double radiusValue, double heightValue) : base(xValue, yValue, zValue, radiusValue)
        {
            Height = heightValue;
        }

        // property Height
        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                // ensure non-negative height value
                if (value >= 0)
                    height = value;
            }
        }

        // calculate Cylinder area
        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }

        // return string representation of Cylinder object
        public override string ToString()
        {
            return base.ToString() + " Height = " + Height;
        }

        // override property Name from class Circle
        public override string Name
        {
            get
            {
                return "Cylinder";
            }
        }

    } // end class Cylinder
}
