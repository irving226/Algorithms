using System;

namespace ShuffleArray
{
    class Program
    {

        
        static void Main(string[] args)
        {
        int[] nums = new int[] { 2, 5, 1, 3, 4, 7 };
        int n = 3;
        Shuffle(nums, n);
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            //first take the array and cut it in half
            //find a way to have those variables held(aray1. array)
            //new array will be filled by each of the contents of the array one by one
            // for each in one, add one from the other..

            int[] arrayOne = new int[n];
            int x = 0;
            for(int i=n; i < nums.Length; i++)
            {
                arrayOne[x] = nums[i];
                x++;
            }
            int[] arrayTwo = new int[nums.Length];

            int y = 0;
            for(int counter=0; counter < arrayTwo.Length; counter++)
            {
                arrayTwo[counter++] = nums[y];
                arrayTwo[counter] = arrayOne[y];
                
               
                y++;
            }
            return arrayTwo;
            
        }
    }
}
