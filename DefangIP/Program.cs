using System;
using System.Collections.Generic;

namespace DefangIP
{
    class Program
    {
        //defang replaces every period '.' in an ip with [.]
        static void Main(string[] args)
        {
            string address = "1.1.01.1.";
            Console.WriteLine(defanIPaddr(address));
            
        }
        public static string defanIPaddr(string address)
        {
            List<char> addressList = new List<char>();
            char[] addressArray = address.ToCharArray();
            foreach(char letter in addressArray)
            {
                if (letter !='.')
                {
                    addressList.Add(letter);
                }
                else
                {
                    addressList.Add('[');
                    addressList.Add('.');
                    addressList.Add(']');
                }
            }

            string addy = "";
            foreach(char item in addressList)
            {
                addy += item;
            }
            return addy;
        }
    }
}
