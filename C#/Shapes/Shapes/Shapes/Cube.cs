//Cube.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cube inherits from ThreeDShape
namespace Shapes
{
    public class Cube : ThreeDShape
    {
        private int width;
        public Cube()
        {
            //implicit call to constructor
        }

        public Cube(int xPoint, int yPoint, int zPoint, int width) : base(xPoint, yPoint, zPoint)
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
        //Cube Volume
        public override double Volume()
        {
            return Math.Pow(Width, 3);
        }
        //Uses ThreeDString's ToString
        public override string ToString()
        {
            return base.ToString() + "Side length = " + Width;
        }

        public override string Name
        {
            get
            {
                return "Cube";
            }
        }
    }
}
