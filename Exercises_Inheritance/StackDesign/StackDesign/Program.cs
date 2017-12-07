using System;

namespace StackDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            int start = 0;
            int end = 10;
            for (int i = start; i <= end; i++)
                stack.Push(i);

            // this will clear the stack and cause an invalid stack exception
            // stack.Clear();

            // stack.Peek() returns top object; but not remove it from stack 
            Console.WriteLine("Item at the top of the stack: " + stack.Peek());

            for (int i = start; i <= end; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}
