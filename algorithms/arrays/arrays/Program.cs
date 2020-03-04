
using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void ArraysDemo()
        {
            int[] arr = {1,2,3,4};
        }

        private static void ArrayTimeComplexity(object[] array)
        {
            Console.WriteLine(array[0]);
            object elementINeedToFind = new object();
            int length = array.Length;
            for (int i = 0; i < length; i++){
                if (array[i] == elementINeedToFind){
                    Console.WriteLine("Exists!");
                }
            }

            var bigArray = new int[length*2];
            Array.Copy(array, bigArray, length);
            bigArray[length + 1] = 10;
        }
    }
}
