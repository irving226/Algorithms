using System;
using System.Collections;
using System.Collections.Generic;

namespace NumberOfRecentPhoneCalls
{


    //REVIEW https://leetcode.com/problems/number-of-recent-calls/solution/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class RecentCounter
        {
            //initializs counter with0 recent requests

            public int[] requests;
            Queue counter;

            public RecentCounter()
            {
                this.counter = new Queue();

            }


            public int Ping(int t)
            {

                int param_1 = Ping(t);
                this.counter.Enqueue(t);

                while (counter.Count < t - 3000)

                {
                    this.counter.Dequeue();


                }
                return this.counter.Count;

            }

            /**
             * Your RecentCounter object will be instantiated and called as such:
             * RecentCounter obj = new RecentCounter();
             * int param_1 = obj.Ping(t);
             */
        }
    }
}
