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
                shape.Draw();
            }
        }
    }
}