using System;
using System.Collections.Generic;
using System.Text;
using OOP_Shape.Shapes;

namespace OOP_Shape
{
    class Drawing
    {
        public List<Shape> Shapes { get; set; }
        public double SpaceCovered { get; }
        public double LinesDrawn { get; }


        public void Draw()
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            Shapes.Add(circle);
            Shapes.Add(rectangle);
            Shapes.Add(triangle);
            foreach (Shape shape in Shapes)
            {
                Console.WriteLine(shape.Aria );
            }

        }
        
        public Drawing()
        {
            Shapes = new List<Shape>();
            SpaceCovered = 10;
            LinesDrawn = 20;
        }
        //public override string ToString()
        //{
        //    return $"A drawing consisting of X {Shapes}. where X is the number of items in “Shapes”.";
        //}
        
        
        
    }
}
