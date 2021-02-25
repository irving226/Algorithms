using System;

namespace LeetCodeExercises
{
    class Program
    {
        //Broken Calculator 
        static void Main(string[] args)
        {
            int x = 5;
            int y = 8;
            int i = 0;

            while (x != y)
            {

                if (x < y)
                {
                    x *= 2;
                    i++;
                   
                }
                else
                {
                    x -= 1;
                    i++;
                    Console.WriteLine($"x is now {x}");
                }
                Console.WriteLine("count=" + i);
            }

        }
    }
}
