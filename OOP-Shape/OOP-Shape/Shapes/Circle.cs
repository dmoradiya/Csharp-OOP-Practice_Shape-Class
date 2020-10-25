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
                return 2 * 3.14 * Radius;
            }
        }
        public override double Aria 
        {
            get
            {
                return 3.14 * Radius*Radius;
            }
        }
        public Circle()
        {
            Radius = 10.00;
        }
        public Circle(string color, double radius): base(color)
        {
            Radius = radius;

            Console.WriteLine("You Selected Circuler Shape");
          
        }
       




    }
}
