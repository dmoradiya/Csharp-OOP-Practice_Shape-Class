using System;
using OOP_Shape.Shapes;

namespace OOP_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing drawing = new Drawing();
            
            drawing.Draw(new Circle());
            drawing.Draw(new Rectangle());
            drawing.Draw(new Triangle());
            Console.WriteLine(drawing);
            Console.WriteLine(drawing.SpaceCovered);
            Console.WriteLine(drawing.LinesDrawn);
        }
    }
}
