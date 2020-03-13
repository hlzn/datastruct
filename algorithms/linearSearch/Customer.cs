using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace linearSearch
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
    }

    public class CustomerComparer : IEqualityComparer<Customer>
    {

        public bool Equals([AllowNull] Customer x, [AllowNull] Customer y)
        {
            return x.Age == y.Age && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Customer obj)
        {
            return obj.GetHashCode();
        }
    }
}