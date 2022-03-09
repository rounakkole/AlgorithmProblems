using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class PrimeInRange
    {
        public void UserInput()
        {
            Console.Write("enter min limit: ");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter max limit: ");
            int Max = Convert.ToInt32(Console.ReadLine());
            PrimeNumber(Min, Max);
        }

        public static void PrimeNumber(int Min, int Max)
        {
            Palindrome palindrome = new Palindrome();
            for (int j = Min; j < Max; j++)
            {
                bool isPrime = true;

                for (int i = 2; i < j; i++)
                {
                    int remainder = j % i;
                    if (remainder == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    bool IsPalindrome = palindrome.CheckPalindrome(j);
                    if (IsPalindrome)
                    {
                        Console.WriteLine($"prime & palindrome: {j}");
                    }
                }
            }
        }
    }
}
