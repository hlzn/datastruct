using System;
using System.Collections.Generic;

namespace hashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // var books = new Dictionary<int, string>();

            // books.Add(3, "The lord of the rings");
            // books.Add(2, "A tale of two cities");

            var number1 = new PhoneNumber(areaCode: "141804", exchange: "27", number: "90319334");
            var number2 = new PhoneNumber(areaCode: "141804", exchange: "27", number: "90319334");
            //var number3 = new PhoneNumber() { AreaCode = "141804", Exchange = "27", Number = "90319334" };

            System.Console.WriteLine(number1.GetHashCode());
            System.Console.WriteLine(number2.GetHashCode());

            System.Console.WriteLine(value:number1==number2);

            System.Console.WriteLine(number1.Equals(number2));

            var customers = new Dictionary<PhoneNumber, Person>();

            customers.Add(number1, new Person());
            //customers.Add(number2, new Person());

            Console.WriteLine(customers.ContainsKey(number1));

            //number1.AreaCode = "141803";

            System.Console.WriteLine(number1.GetHashCode());

            System.Console.WriteLine(customers.ContainsKey(number1));

            System.Console.WriteLine(value:"After adding phone numbers.");

            var c = customers[number2];

            System.Console.WriteLine(c.Age);

            Console.ReadLine();



            Console.WriteLine("Hello World!");
        }
    }
}
