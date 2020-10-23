using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    abstract class Shapes
    {

        public abstract string Aria { get; }
        public abstract string Perimeter { get; }
        public string Color { get; set; }
    }
}
