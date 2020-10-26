using System;
using System.Collections.Generic;
using System.Text;
using OOP_Shape.Shapes;

namespace OOP_Shape
{
    class Drawing
    {
        private List<Shape> Shapes { get; set; }
        public double SpaceCovered
        {
            get
            {
                double total = 0;
                foreach (Shape type in Shapes)
                {
                    total += type.Aria;
                }
                return total;
            }
        }
        public double LinesDrawn
        { 
            get
            {
                double total = 0;
                foreach (Shape type in Shapes)
                {
                    total += type.Perimeter;
                }
                return total;
            }
                
        }
        


        public void Draw(Shape shape) // Polymorphism
        {
            //Circle circle = new Circle();
            //Rectangle rectangle = new Rectangle();
            //Triangle triangle = new Triangle();
            //Shapes.Add(circle);
            //Shapes.Add(rectangle);
            //Shapes.Add(triangle);
            
            Shapes.Add(shape);
           

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
