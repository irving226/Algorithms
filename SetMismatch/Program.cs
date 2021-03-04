using System;

namespace SetMismatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 3 };
            FindErrorNums(nums);
            Console.WriteLine(nums.ToString());

        }

        public static int[] FindErrorNums(int[] nums)
        {
            int[] results = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {

                    //if pair is found
                    if (nums[i] == nums[j])
                    {
                        //index 0 of result array will be the double
                        results[0] = nums[j];
                        int n = nums.Length;
                        int sum = 0;
                        foreach (int x in nums)
                        {
                            sum += x;
                        }
                        int equate = (n * (n + 1))/2;
            results[1] = equate + results[0] - sum;


        
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return results;
        }
    }
}
