using System;
using System.Collections.Generic;
using System.Linq;

namespace challenges {
    class StringRepeat {
        public static int check(string s, long n){
            decimal t = (decimal)n/s.Length;
            decimal missed = (t-Math.Floor(t))*s.Length;
            int plus = (int)Math.Ceiling(missed);
            string complete = String.Concat(Enumerable.Repeat(s, (int)Math.Floor(t)));
            complete += s.Substring(0, plus);
            List<string> strings = new List<string>();
            int times = (int)Math.Ceiling((double)n/int.MaxValue);
            char[] xcomplete = complete.ToCharArray();
            for (var x = 0; x < times; x++){
                
            }
            return complete.Split('a').Length - 1;
        }
        public static void RepeatThis() {
            long chars = 1000000000000;
            string content = "a";
            Console.WriteLine(check(content, chars));
        }
    }
}