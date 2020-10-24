using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    abstract class Shape
    {

        //abstract public  double Aria { get; }
        abstract public double Perimeter { get; }
        public string Color { get; set; }


        public Shape()
        {
           
            Color = "Black";
        }
        public Shape(string color)
        {
           
            Color = color;
        }
    }
}
