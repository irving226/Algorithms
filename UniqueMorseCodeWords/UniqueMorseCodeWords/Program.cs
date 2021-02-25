using System;
using System.Collections.Generic;

namespace UniqueMorseCodeWords
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] input = new string[4] { "gin", "zen", "gig", "msg" };
            string[,] morseCode = new string[26, 2] { { "a", ".-" }, { "b", "-..." }, { "c", "-.-." }, { "d", "-.." }, { "e", "." }, { "f", "..-." }, { "g", "--." }, { "h", "...." }, { "i", ".." }, { "j", ".---" }, { "k", "-.-" }, { "l", ".-.." }, { "m", "--" }, { "n", "-." }, { "o", "---" }, { "p", ".--." }, { "q", "--.-" }, { "r", ".-." }, { "s", "..." }, { "t", "-" }, { "u", "..-" }, { "v", "...-" }, { "w", ".--" }, { "x", "-..-" }, { "y", "-.--" }, { "z", "--.." } };


            Console.WriteLine(Counter(input, morseCode));


            static int Counter(string[] input, string[,] morseCode)
            {
                int count = 1;
                HashSet<String> completedMorse = new HashSet<string>();
                foreach (string word in input)
                {
                    string morseCodeWord = "";

                    char[] letters = word.ToCharArray();

                    foreach (char letter in word.ToCharArray())
                    {
                        //figure whatmorse code for letter is w/o loop and add it to morsecodeword
                        int col = 0;
                        while (letter.ToString() != morseCode[col, 0])
                        {
                            col++;
                        }
                        morseCodeWord += morseCode[col, 1];
                        Console.WriteLine(morseCodeWord);


                    }
                    completedMorse.Add(morseCodeWord);



                }
                 foreach(string s in completedMorse)
                {
                    Console.WriteLine(s);
                }
                return completedMorse.Count;



                
            }
            }
          
            }
        }
    
            
        
    


