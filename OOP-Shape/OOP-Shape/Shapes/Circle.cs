using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    class Circle : Shapes
    {

        public double Radius { get; set; }
        public double Diameter
        {
            get
            {
                return 2 * Radius;
            }
        }
        public override double Perimeter
        {
            get
            {
                return 2*3.14*Radius;
            }
        }

    }
}
