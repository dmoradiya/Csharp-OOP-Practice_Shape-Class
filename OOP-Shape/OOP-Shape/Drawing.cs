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
        


        public void Draw(Shape shape) // Polymorphism
        {
            //Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();
            //Triangle triangle = new Triangle();
            //Shapes.Add(circle);
            //Shapes.Add(rectangle);
            //Shapes.Add(triangle);
            
            Shapes.Add(shape);
            foreach (Shape type in Shapes)
            {

                Console.WriteLine($"Aria : {type.Aria}\nPerimeter : {type.Perimeter}");                
            }

        }
        
        public Drawing()
        {
            Shapes = new List<Shape>();
           
            
        }
        public override string ToString()
        {
            return $"A drawing consisting of  {Shapes.Count} Shape. where {Shapes.Count} is the number of items in “Shapes”.";
        }



    }
}
