using System;
using System.Collections.Generic;

namespace LetterCasePermutation
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {
            string S = "a1b2";
            LetterCasePermutation(S);

            Console.WriteLine();

        }
             static IList<string> LetterCasePermutation(string S)
        {
          


            IList<string> leetList = new List<string>();
            leetList.Add(S);
            char[] letters = S.ToCharArray();


            for (int i = 0; i < letters.Length-1; i++)
            {
                for (int j = 0; j < letters.Length-(1+i); j++)
                {
                    if (letters[j]< letters[j+1])
                    {
                        char temp = letters[j + 1];
                        letters[j + 1] = letters[j];
                        letters[j] = temp; 

                    }
                }
            }
          
            string ox = new string(letters);
            do
            {
                
                letters = ox.ToCharArray();
               


                {


                    if ((char)letters[x] >= 'A' && letters[x] <= 'Z')
                    {
                         
                        letters[x] = char.ToLower(letters[x]);
                        string s = new string(letters);
                        leetList.Add(s);
                        letters = ox.ToCharArray();
                        x++;
                       


                    }
                    else if (letters[x] >= 'a' && letters[x] <= 'z')
                    {
                        
                        letters[x] = char.ToUpper(letters[x]);
                        string s = new string(letters);
                        leetList.Add(s);
                        letters = ox.ToCharArray();
                        
                        x++;
                       


                    }
                    else
                    {
                        string s = new string(letters);
                        leetList.Add(s);
                        letters = ox.ToCharArray();

                    }


                }

           

            }

            while (Char.IsLetter(letters[x]));
          
            string allCap = new string(letters);
           allCap = allCap.ToUpper();
            leetList.Add(allCap);
            Console.WriteLine(allCap);

            for (int i = 0; i < leetList.Count; i++)
            {
                Console.WriteLine(leetList[i]);
            }

            return leetList;

        }


    }
} 

