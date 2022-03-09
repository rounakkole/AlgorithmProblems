// See https://aka.ms/new-console-template for more information
using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("algorithm problems");
            PrimeInRange primeInRange = new PrimeInRange();
            primeInRange.UserInput();
        }
    }
}
