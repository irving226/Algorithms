using System;
using System.Collections.Generic;

namespace LeetCodeExercises
{
    class Program
    {
        //1431 Kids W Greatest # of Candies 
        static void Main(string[] args)
        {
            int[] candies = new int[] { 2, 3, 5, 2, 3 };
            int extraCandies = 3;
            Console.WriteLine(KidsWithCandies(candies, extraCandies));
        }
          public static IList<bool> KidsWithCandies(int[] candies, int extraCandies) {

            //iterate thru the array and find the largest number
            //store that (x)
            //iterate again and find out for each kid(num) in the array, how far away from 
            //the largest num are they. 
            //the extraCandies var will determine if the method prints true or false. 
            //true=kid will have highest num, false otherwise
            IList<bool> candyTally = new List<bool>();
            int x = candies[0];
            for(int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > x)
                {
                    x = candies[i];
                }
            }
            foreach(int num in candies)
            {
                if (num + extraCandies  >= x)
                {
                    candyTally.Add(true);
                }
                else
                {
                    candyTally.Add(false);
                }
            }
            return candyTally;
        
             }


        
    }
   
}

