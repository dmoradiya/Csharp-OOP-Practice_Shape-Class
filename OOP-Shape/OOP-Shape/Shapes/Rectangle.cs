using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }
        public override double Perimeter
        {
            get
            {
                return 2 *Length + 2*Width ;
            }
        }
        public override double Aria
        {
            get
            {
                return Length*Width;
            }
        }

        public Rectangle()
        {
            Length = 10;
            Width = 5;
        }
    }
   
}
