//Shape.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Demonstrate a shape hierarchy using an abstract base class.

namespace Shapes
{
    public abstract class Shape
    {
        // Return Shape's name
        public override abstract string ToString();
        public abstract string Name
        {
            get;
        }
    }
}
