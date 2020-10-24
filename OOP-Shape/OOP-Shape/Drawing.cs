using System;
using System.Collections.Generic;
using System.Text;
using OOP_Shape.Shapes;

namespace OOP_Shape
{
    class Drawing
    {
        public List<Shape> shapes { get; set; }
        public double SpaceCovered { get; }
        public double LinesDrawn { get; }


        public void Draw(Shape shape)
        {
            shapes.Add(shape);
        }
        
        
        
    }
}
