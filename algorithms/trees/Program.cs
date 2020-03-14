using System;

namespace trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var bstTest = new BST<int>();
            bstTest.Insert(37);
            bstTest.Insert(24);
            bstTest.Insert(17);
            bstTest.Insert(28);
            bstTest.Insert(31);
            bstTest.Insert(29);
            bstTest.Insert(15);
            bstTest.Insert(12);
            bstTest.Insert(20);
            

            foreach(var i in bstTest.TraverseInOrder())
            {
                Console.Write(value:$"{i} ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine(bstTest.Min());
            System.Console.WriteLine(bstTest.Max());

            System.Console.WriteLine(bstTest.Get(value:20).Value);

            
            
            Console.ReadLine();












            Console.WriteLine("Hello World!");
        }
    }
}
