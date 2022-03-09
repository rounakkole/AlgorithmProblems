﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class MergeSort
    {
        public void UserInput <T> ()
        {
            string GivenString = "Mango Coconut Pineapple Apple Banana Papaya Cherry Watermelon Orange Grapes";
            string[] SplitString = GivenString.Split(" ");
            Console.Write("given string : ");
            Display<string>(SplitString);
            string[] SortedString = Sort(SplitString, 0, SplitString.Length - 1);
            Console.Write("\n sorted string: ");
            Display(SortedString);
        }

        public static void Merge <T> (T[] GivenString, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            T[] left = new T[n1];
            T[] right = new T[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
            {
                left[i] = GivenString[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                right[j] = GivenString[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (Comparer<T>.Default.Compare(left[i], right[j]) <= 0)

                {
                    GivenString[k] = left[i];
                    i++;
                }
                else
                {
                    GivenString[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                GivenString[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                GivenString[k] = right[j];
                j++;
                k++;
            }
        }
        public static T[] Sort <T> (T[] GivenString, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                Sort(GivenString, l, m);
                Sort(GivenString, m + 1, r);
                Merge(GivenString, l, m, r);
            }
            return GivenString;
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
