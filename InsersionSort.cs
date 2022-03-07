using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class InsersionSort
    {
        public void UserInput()
        {
            string GivenString = "Mango Coconut Pineapple Apple Banana Papaya Cherry Watermelon Orange Grapes";
            string[] SplitString = GivenString.Split(" ");
            Console.Write("given string : ");
            Display(SplitString);
            InsertionSort(SplitString);
        }
        public static void InsertionSort(string[] GivenString)
        {
            for (int i = 1; i < GivenString.Length; i++)
            {
                string temp = GivenString[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (GivenString[j].CompareTo(temp) > 0)
                    {
                        GivenString[j + 1] = GivenString[j];
                        GivenString[j] = temp;
                    }
                }
            }
            Console.Write("\n sorted string: ");
            Display(GivenString);
        }

        public static void Display(string[] GivenString)
        {
            foreach (string Strings in GivenString)
            {
                Console.Write(Strings + " ");
            }
        }
    }
}
