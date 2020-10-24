using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    class Circle : Shape
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
            Radius = 10;
            Console.WriteLine("You Selected Circle Shape");
          
        }
       




    }
}
