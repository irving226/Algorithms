using System;
using System.Collections.Generic;

namespace DistributedCandies
{
    class Program
    {

        //March Week 1: 1st-7th
        static void Main(string[] args)
        {
      
        }

        public int DistributedCandies(int[] candyType)
        {
            HashSet<int> candyTypes = new HashSet<int>();
            int docRec = candyType.Length / 2;

            foreach(int candy in candyType)
            {
                candyTypes.Add(candy);
            }
            if(candyTypes.Count==docRec|| candyTypes.Count > docRec)
            {
                return docRec;
            }
            else
            {
                return candyTypes.Count;
            }
        }
    }
}
