using System;
namespace challenges {
    class Hiking {

        // Complete the countingValleys function below.
        static int countingValleys(int n, string s) {
            int valleys = 0;
            int position = 0; 
            int last = 0;
            int move = 0;
            move = s[0] == 'D' ? -1 : 1; 
            position += move;
            for (var i = 1; i < s.Length; i++){
                last = position;
                move = s[i] == 'D' ? -1 : 1; 
                position += move;
                if (position == 0 && last < 0){
                    valleys += 1;
                }
            }
            return valleys;
        }

        public static void Hike() {
            int n = 12;//Convert.ToInt32(Console.ReadLine());
            string s = "DDUUDDUDUUUD"; //Console.ReadLine();
            int result = countingValleys(n, s);

            Console.WriteLine(result);
        }
    }
}