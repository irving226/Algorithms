using System;
using System.Collections.Generic;
using System.Text;



namespace LeetCodeExercises
    {
    class ShuffleString
    {

        static void Main(string[] args)
        {
            string s = "codeleet";
            int[] indices = new int[] { 4, 5, 6, 7, 0, 2, 1, 3 };
         

            RestoreString(s, indices);

        }


            public static string RestoreString(string s, int[] indices)
            {
                //create new array equal to indices length
                //loop thru, and for each num you find, you'll set that 
                //char to that specified pos. in the new array
                char[] sArray = s.ToCharArray();
                char[] solution = new char[indices.Length];
                int i = 0;

                foreach (int num in indices)
                {
                    //for each letter in the char array,
                    //grab the number from the indices array and set that number 
                    //as the position of the char 
                    solution[num] = sArray[i++];
                }
                string answer = "";

                foreach (char c in solution)
                {
                    answer += c;
                }
                return answer;
            }
        
    }
    }


