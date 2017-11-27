﻿using System;

namespace Method_Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
//            // Any code specific to the circle itself
//            base.Draw();
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            
        }
    }
}