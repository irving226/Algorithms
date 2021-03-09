using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichestCustomerWealth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = new int[2][];

            accounts[0] = new int[3] { 1, 2, 3 };
            accounts[1] = new int [3] { 3, 2, 1 };

            MaximumWealth(accounts);

        }

        public static int MaximumWealth(int[][] accounts)
        {
            int counter = 0;
            int savedCounter=0;

           for(int i = 0; i < accounts.Length; i++)
            {
                counter = 0;
                foreach (int nums in accounts[i])
                {
                    counter += nums;
                }
                if (counter > savedCounter)
                {
                    savedCounter= counter;
                }


            }


            return savedCounter;
        }
    }
}

