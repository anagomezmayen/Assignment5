using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment5
{
    class Question6
    {
        //I'm using small case letter of the English alphabet

        static public void FirstNonRepeatingCharacter(string stream)
        {
            List<char> inList = new List<char>();
            bool[] repeated = new bool[26];// all elements in array are false
            string done = "( ";

            foreach (char c in stream)
            {
                Console.Write("{0}  goes to stream: ", c);
                done+=c+", ";
                if (!repeated[c - 97])
                {//position 0
                    if (!inList.Contains(c))
                    {
                        inList.Add(c);
                    }
                    else
                    {
                        inList.Remove(c);
                        repeated[c - 97] = true;
                    }
                }
                if (inList.Count == 0)
                {
                    Console.WriteLine("no non repeating element -1 {0} )", done.Remove(done.Length - 2, 2));
                }
                else
                {
                    Console.WriteLine("1st non repeating element is {0} {1} )", inList[0], done.Remove(done.Length-2,2));
                }
            }
        }


        static public void Main(string[] args)
        {
            string myStream= "aabc";

            FirstNonRepeatingCharacter(myStream);
            Console.Write("\n");

            string myStream2 = "abcaeeb";
            FirstNonRepeatingCharacter(myStream2);


        }
    }
}
