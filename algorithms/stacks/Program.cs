using System;
using System.Collections.Generic;

namespace stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            System.Console.WriteLine($"Should print 4: {stack.Peek()}");

            stack.Pop();

            System.Console.WriteLine($"Should print 3: {stack.Peek()}");

            System.Console.WriteLine("Iteration:");

            foreach(var obj in stack)
            {
                System.Console.WriteLine(obj);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
