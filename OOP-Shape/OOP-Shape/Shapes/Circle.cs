using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    class Circle : Shape // Inheritance 
    {

        public double Radius { get; set; }
        public double Diameter
        {
            get
            {
                return 2 * Radius; // Encapsulation
            }
        }
        public override double Perimeter // Abstraction
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);  // same as  : 3.14 * Radius * Radius;

            }
        }
        public override double Aria 
        {
            get
            {
                return 3.14 * Radius*Radius;
            }
        }
        public Circle() : base()
        {
            Radius = 10.00;
            
        }
        public Circle(string color, double radius): base(color)
        {
            Radius = radius;        
        }
       




    }
}
