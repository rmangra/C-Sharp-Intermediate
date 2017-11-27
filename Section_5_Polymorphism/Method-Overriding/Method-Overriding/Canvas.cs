using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    public class Canvas
    {
        public void Drawshapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle");
                        break;

                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle");
                        break;
                }
            }
        }
    }
}