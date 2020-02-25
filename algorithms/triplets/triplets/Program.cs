using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace triplets
{
    class Program
    {
        static void Main(string[] args)
        {

            var ints = In.ReadInts("1Kints.txt").ToArray();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var triplets = ThreeSum.Count(ints);
            watch.Stop();
            Console.WriteLine(String.Format("The number of zero sum triplets is {0} for 1Kints, process performed in {1} seconds.", triplets, watch.Elapsed));

            ints = In.ReadInts("2Kints.txt").ToArray();
            watch = new Stopwatch();
            watch.Start();
            triplets = ThreeSum.Count(ints);
            watch.Stop();
            Console.WriteLine(String.Format("The number of zero sum triplets is {0} for 2Kints, process performed in {1} seconds.", triplets, watch.Elapsed));

            ints = In.ReadInts("4Kints.txt").ToArray();
            watch = new Stopwatch();
            watch.Start();
            triplets = ThreeSum.Count(ints);
            watch.Stop();
            Console.WriteLine(String.Format("The number of zero sum triplets is {0} for 4Kints, process performed in {1} seconds.", triplets, watch.Elapsed));

            ints = In.ReadInts("8Kints.txt").ToArray();
            watch = new Stopwatch();
            watch.Start();
            triplets = ThreeSum.Count(ints);
            watch.Stop();
            Console.WriteLine(String.Format("The number of zero sum triplets is {0} for 8Kints, process performed in {1} seconds.", triplets, watch.Elapsed));

            ints = In.ReadInts("16Kints.txt").ToArray();
            watch = new Stopwatch();
            watch.Start();
            triplets = ThreeSum.Count(ints);
            watch.Stop();
            Console.WriteLine(String.Format("The number of zero sum triplets is {0} for 16Kints, process performed in {1} seconds.", triplets, watch.Elapsed));


            Console.ReadLine();
        }
    }
}
