using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class BubbleSort
    {

        public void UserInput<T>()
        {
            string GivenString = "Mango Coconut Pineapple Apple Banana Papaya Cherry Watermelon Orange Grapes";
            string[] SplitString = GivenString.Split(" ");
            Console.Write("given string : ");
            Display(SplitString);
            BubbleSorting(SplitString);
        }

        public static void BubbleSorting<T>(T[] GivenString)
        {
            for (int itr = 0; itr <= GivenString.Length - 1; itr++)
            {
                T temp;
                for (int j = 0; j < GivenString.Length - 1 - itr; j++)
                {
                    if (Comparer<T>.Default.Compare(GivenString[j], GivenString[j + 1]) > 0)
                    {
                        temp = GivenString[j + 1];
                        GivenString[j + 1] = GivenString[j];
                        GivenString[j] = temp;
                    }
                }

            }
            Console.Write("\n sorted string: ");
            Display(GivenString);
        }

        public static void Display<T>(T[] GivenString)
        {
            foreach (T Strings in GivenString)
            {
                Console.Write(Strings + " ");
            }
        }
    }
}
