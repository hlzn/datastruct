using System;
namespace challenges {
    class CloundJumping {
        private static int Jump(int[] c){
            int j = 0;
            for (var i = 0; i < c.Length; i++){
                j += i == 0 ? 0 : 1;
                i += i+2 < c.Length ? c[i+2] == 0 ? 1 : 0 : 0;
            }
            return j;
        }
        public static void Jumping(){
            int[] c = {0, 0, 0, 1, 0, 0};
            
            Console.WriteLine(Jump(c));
        }
    }
}