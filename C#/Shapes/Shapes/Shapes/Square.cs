//Square.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : TwoDShape
    {
        private int width;
        public Square()
        {
            //implicit call to constructor
        }

        public Square(int xPoint, int yPoint, int width) : base(xPoint, yPoint)
        {
            Width = width;
        }
        //Width property
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                //ensure non-negative side value
                if(value >= 0)
                    width = value;
            }
        }
        //Square Perimeter
        public override double Perimeter()
        {
            return Width * 4;
        }
        //Square Area
        public override double Area()
        {
            return Width * Width;
        }
        //Uses TwoDShape's ToString + Width
        public override string ToString()
        {
            return base.ToString() + "; Width = " + Width;
        }

        public override string Name
        {
            get
            {
                return "Square";
            }
        }
    }
}
