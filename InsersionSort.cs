using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class InsersionSort
    {
        public void UserInput<T>()
        {
            string GivenString = "Mango Coconut Pineapple Apple Banana Papaya Cherry Watermelon Orange Grapes";
            string[] SplitString = GivenString.Split(" ");
            Console.Write("given string : ");
            Display(SplitString);
            InsersionSorting(SplitString);
        }
        public static void InsersionSorting <T> (T[] GivenString)
        {
            for (int i = 1; i < GivenString.Length; i++)
            {
                T temp = GivenString[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Comparer<T>.Default.Compare(GivenString[j], temp) > 0)
                    {
                        GivenString[j + 1] = GivenString[j];
                        GivenString[j] = temp;
                    }
                }
            }
            Console.Write("\n sorted string: ");
            Display(GivenString);
        }

        public static void Display <T> (T[] GivenString)
        {
            foreach (T Strings in GivenString)
            {
                Console.Write(Strings + " ");
            }
        }
    }
}
