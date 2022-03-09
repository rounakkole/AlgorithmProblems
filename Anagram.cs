using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class Anagram
    {
        public string String1;
        public string String2;
        public static bool IsAnagram = false;

        public Anagram(string string1, string string2)
        {
            String1 = string1;
            String2 = string2;
            bool IsAnagram = Recursion(String1, String2, 0);
            string Result = IsAnagram ? "anagram" : "not anagram";
            Console.WriteLine(Result);
        }

        public static bool Recursion(string String1, string String2, int start)
        {
        
            int Length = String1.Length;
     
            
                for (int i = start; i < Length; i++)
                {
                    String1 = (Swap(String1, start, i));
                    if (String1 == String2)
                    {
                        IsAnagram = true;
                        break;
                    }
                    Recursion(String1, String2, start + 1);
                    String1 = Swap(String1, start, i);
            }
            return IsAnagram;
        }

        public static string Swap(string Sentence, int start, int end)
        {
            char temp;
            char[] charArray = Sentence.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string s = new string(charArray);
            return s;
        }

    }
}
