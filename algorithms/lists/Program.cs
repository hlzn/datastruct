using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lists
{
    public class Customer
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    class Program
    {
        public static void Run()
        {
            List<int> list = new List<int>();
            LogCountAndCapacity(list);
            for (var i = 0; i < 16; i++)
            {
                list.Add(i);
                LogCountAndCapacity(list);
            }
            for (int i = 10; i > 0; i--)
            {
                list.RemoveAt(i - 1);
                LogCountAndCapacity(list);
            }
            list.TrimExcess();
            LogCountAndCapacity(list);
            list.Add(1);
            LogCountAndCapacity(list);
        }

        public static void ApiMembers()
        {
            var list = new List<int>() { 1, 0, 5, 3, 4 };
            list.Sort();

            int indexBinSearch = list.BinarySearch(3);
            list.Reverse();
            
            ReadOnlyCollection<int> readOnlyList = list.AsReadOnly();
            int[] array = list.ToArray(); 

            var listCustomers = new List<Customer>()
            {
                new Customer { Name = "Juan", Birthday = new DateTime(1,1,2001) },
                new Customer { Name = "Tom", Birthday = new DateTime(1,1,2003) },
                new Customer { Name = "Pepe", Birthday = new DateTime(1,1,2002) }
            };
            listCustomers.Sort((left, right) =>
            {
                if (left.Birthday > right.Birthday)
                {
                    return 1;
                }
                if (right.Birthday > left.Birthday)
                {
                    return -1;
                }
                return 0;
            });
        }

        private static void LogCountAndCapacity(List<int> list)
        {
            Console.WriteLine($"Count={list.Count}. Capacity={list.Capacity}");
        }

        // static void Noding()
        // {
        //     Node first = new Node(5);
        //     Node second = new Node(1) { Value = 1 };

        //     first.Next = second;

        //     Node third = new Node(3) { Value = 3 };
        //     third.Next = second;

        //     PrintOutLinkedList(first);

        // }

        // static void PrintOutLinkedList(Node node)
        // {
        //     while (node != null)
        //     {
        //         Console.WriteLine(node.Value);
        //         node = node.Next;
        //     }
        // }

        static void Main(string[] args)
        {
            //Noding();
            Console.ReadLine();
        }
    }
}
