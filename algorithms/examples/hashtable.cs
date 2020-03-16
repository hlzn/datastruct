using System;
using System.Collections;
using System.Collections.Generic;

namespace examples
{
    struct userInfoHash
    {

    }

    public class htexample
    {
        public Hashtable userInfoHash;

        public void runExample()
        {
            userInfoHash = new Hashtable();

            //adding
            for (int i=0; i < 10; i++)
            {
                userInfoHash.Add(i, "user"+i);
            }

            //removing
            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }

            //setting
            if (userInfoHash.ContainsKey(1))
            {
                userInfoHash[1] = "replacementNAme";
            }

            //looping
            foreach(DictionaryEntry entry in userInfoHash)
            {
                System.Console.WriteLine($"key: {entry.Key}. value: {entry.Value}.");
            }
        }
    }


    public class iceCreamExample
    {
        //brute force
        public int[] find_bf(int amount, int[] array){
            for(var i = 0; i < array.Length; i++){
                for(var j = i; j < array.Length; j++){
                    if ((array[i] + array[j]) == amount) {
                        return new int[2] { ++i, ++j };
                    }
                }
            }
            return new int[2] {-1, -1};
        }

        public int[] find(int amount, int[] array){
            Hashtable amounts = getOptions(array);
            for(var i = 0; i < array.Length; i++){
                if (amounts.ContainsKey(amount-array[i])){
                    int results = (int)amounts[amount-array[i]];
                    return new int[2] { ++i, ++results };
                }
            }
            return new int[2] {-1,-1};
        }

        public Hashtable getOptions(int[] array){
            Hashtable h = new Hashtable();
            for(var i = 0; i < array.Length; i++){
                h.Add(array[i], i);
            }
            return h;
        }

        public void start(){
            int amount = 9;
            int[] iceCreams =  {1, 3, 4, 6, 7, 9};
            int[] whichOnes = find_bf(amount, iceCreams);
            System.Console.WriteLine($"icecream 1: {whichOnes[0]} - 2: {whichOnes[1]}");
        }
    }
}