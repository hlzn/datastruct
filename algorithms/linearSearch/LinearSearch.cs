using System;
using System.Collections.Generic;
using System.Linq;

namespace linearSearch
{
    public class LinearSearchs
    {
        public List<Customer> customerList = new List<Customer>()
        {
            new Customer { Age = 3, Name = "Ann" },
            new Customer { Age = 16, Name = "Bill" },
            new Customer { Age = 20, Name = "Rose" },
            new Customer { Age = 14, Name = "Rob" },
            new Customer { Age = 28, Name = "Bill" },
            new Customer { Age = 14, Name = "John" }
        };

        public List<int> intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12, 3, 2, 1 };

        private static bool Exists(int[] array, int number)
        {
            for(var i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private static int IndexOf(int[] array, int number)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Execute()
        {
            bool contains = intList.Contains(3);
            bool contains2 = customerList.Contains(new Customer{ Age = 14, Name = "Rob"}, new CustomerComparer());

            bool exists = customerList.Exists(customer => customer.Age == 28);
            int min = intList.Min();
            int max = intList.Max();

            int youngestCustomerAge = customerList.Min(customer => customer.Age);

            Customer bill = customerList.Find(customer => customer.Name == "Bill");
            Customer lastBill = customerList.FindLast(customer => customer.Name == "Bill");
            Customer lastBill2 = customerList.Last(customer => customer.Name == "Bill");

            List<Customer> customers = customerList.FindAll(customer => customer.Age > 18);
            IEnumerable<Customer> whereAge = customerList.Where(customer => customer.Age > 18);

            int index1 = customerList.FindIndex(customer => customer.Age == 14);
            
        }
    }
}