using System;

namespace trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var heapTest = new MaxHeap<int>();
            heapTest.Insert(24);
            heapTest.Insert(37);
            heapTest.Insert(17);
            heapTest.Insert(28);
            heapTest.Insert(31);
            heapTest.Insert(29);
            heapTest.Insert(15);
            heapTest.Insert(20);

            System.Console.WriteLine(heapTest.Peek());

            System.Console.WriteLine(heapTest.Remove());

            System.Console.WriteLine(heapTest.Peek());

            heapTest.Insert(40);
            
            System.Console.WriteLine(heapTest.Peek());

            foreach(var val in heapTest.Values())
            {
                System.Console.Write($"{val} ");
            }

            Console.ReadLine();









            // var bstTest = new BST<int>();
            // bstTest.Insert(37);
            // bstTest.Insert(24);
            // bstTest.Insert(17);
            // bstTest.Insert(28);
            // bstTest.Insert(31);
            // bstTest.Insert(29);
            // bstTest.Insert(15);
            // bstTest.Insert(12);
            // bstTest.Insert(20);
            

            // foreach(var i in bstTest.TraverseInOrder())
            // {
            //     Console.Write(value:$"{i} ");
            // }

            // System.Console.WriteLine();
            // System.Console.WriteLine(bstTest.Min());
            // System.Console.WriteLine(bstTest.Max());

            // System.Console.WriteLine(bstTest.Get(value:20).Value);

            
            
            // Console.ReadLine();












            Console.WriteLine("Hello World!");
        }
    }
}
