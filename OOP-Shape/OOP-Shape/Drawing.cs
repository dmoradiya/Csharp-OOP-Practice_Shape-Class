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
        public double shapeAria;
        public double shapePerimeter;
        


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
                
                shapePerimeter = type.Perimeter;
                shapeAria = type.Aria;
            }

        }
        
        public Drawing()
        {
            Shapes = new List<Shape>();
            
        }
        public override string ToString()
        {
            return $"A drawing consisting of X Shape. where X is the number of items in “Shapes”, Area :{shapeAria} Peremeter :{shapePerimeter}";
        }



    }
}
