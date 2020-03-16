using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 22, 31, 43, 1, 4, 78, 54, 23, 87, 44, 32, 42, 15 };
            //int[] test = { 9, 2, 6, 4, 3, 5, 1 };
            myQuickSorting2.quicksort(test);
            Console.ReadLine();
        }
    }
}
