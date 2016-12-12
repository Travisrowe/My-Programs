//Sphere.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sphere inherits from ThreeDShape
namespace Shapes
{
    public class Sphere : ThreeDShape
    {
        Point center;
        private double radius;
        private double height; // Sphere height

        // default constructor
        public Sphere()
        {
            // implicit call to Sphere constructor occurs here
        }

        // constructor
        public Sphere(int xValue, int yValue, int zValue, double radiusValue)
        {
            center = new Point(xValue, yValue, zValue);
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
                if (value >= 0)
                    radius = value;
            }
        }
        
        // calculate Sphere area
        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 3) * 4 / 3;
        }

        // return string representation of Sphere object
        public override string ToString()
        {
            return "Center = " + center + "; Radius = " + Radius;
        }

        // override property Name from class Circle
        public override string Name
        {
            get
            {
                return "Sphere";
            }
        }
    }
}
