using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public override double Perimeter
        {
            get
            {
                return 3 * Base;
            }
        }
        public override double Aria
        {
            get
            {
                return 0.5 * Base * Height; ;
            }
        }

        public Triangle() : base()
        {
            Base = 10;
            Height = 20;
        }
        public Triangle(string color, double bottom, double height) : base(color)
        {
            Color = color;
            Base = bottom;
            Height = height;
        }


    }
}
