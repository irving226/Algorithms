using System;

namespace TwoSum
{
    class Program
    {

        //#1-Easy-TwoSum
        static void Main(string[] args)
        {
            int[] nums = new int[2] {3,3};
            int target = 6;
            TwoSum(nums, target);
            
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];

            //iterate thru the array, taking the first element {2} and adding it to the second
            //to see if it equals the target(if statement)
            if (nums.Length == 0)
            {
                return output;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = nums.Length-1; j > i; j--)
                {
                    int x = nums[i];
                    int y = nums[j];


                    if (x + y == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;


                    }
                }
                if (output[0] + output[1] == target)
                {
                    break;
                }
            }
            foreach(int one in output)
            {
                Console.WriteLine(one);
            }
            return output;
        }
    }
}

