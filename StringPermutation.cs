using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class StringPermutation
    {
        public void UserInput()
        {
            Console.WriteLine("permutations of a String");
            Console.Write("Enter: ");
            string Sentence = Console.ReadLine();
            Recursion(Sentence,0);
            Iterative(Sentence);
        }

        public static void Recursion(string Sentence, int start)
        {
            int Length = Sentence.Length;

            for (int i = start; i < Length; i++)
            {
                Sentence = (Swap(Sentence, start, i));
                Console.WriteLine(Sentence);
                Recursion(Sentence, start+1);
                Sentence = Swap(Sentence, start, i);
            }
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


        public static void Iterative(string Sentence)
        {

        }
    }
}
