using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class Palindrome
    {
        public bool CheckPalindrome(int Number)
        {
            int Reminder = 0;
            int ReverseNumber = 0;
            int Temp = Number;
            while (Temp > 0)
            {
                Reminder = Temp % 10;
                Temp = Temp / 10;
                ReverseNumber = ReverseNumber * 10 + Reminder;
            }
            return ReverseNumber == Number ? true : false;
        }
    }
}
