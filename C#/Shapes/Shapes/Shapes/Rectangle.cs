//Rectangle.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rectangle inherits from Square
namespace Shapes
{
    public class Rectangle : Square
    {
        private int height;

        public Rectangle()
        {
            //implicit call to constructor
        }
        public Rectangle(int x, int y, int width, int height) : base(x, y, width)
            {
                Height = height;
            }
        // Height property
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0)
                    height = value;
            }
        }
        //Rectangle Perimeter
        public override double Perimeter()
        {
            return Width * 2 + Height * 2; 
        }
        //Rectangle Area
        public override double Area()
        {
            return Width * Height;
        }
        //Uses Square's ToString + Height
        public override string ToString()
        {
            return base.ToString() + " Height = " + Height;
        }
        public override string Name
        {
            get
            {
                return "Rectangle";
            }
        }
    }
}
