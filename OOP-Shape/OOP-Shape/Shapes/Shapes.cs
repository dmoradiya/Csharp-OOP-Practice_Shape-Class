using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    abstract class Shapes
    {

        //abstract public  double Aria { get; }
        abstract public double Perimeter { get; }
        public string Color { get; set; }


        public Shapes()
        {
           
            Color = "Black";
        }
        public Shapes(string color)
        {
           
            Color = color;
        }
    }
}
