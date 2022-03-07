using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    internal class WordList
    {
        public void UserInput()
        {
            Console.Write($"enter word: ");
            string Search = Console.ReadLine();
            Searching(Search);
        }

        static void Searching(string Search)
        {
            List<string> wordsList = new List<string>();
            wordsList.Add("Read in a list of words from File.Then prompt the user to enter a word to search the list. The program reports if the search word is found in the list.");
            string[] words = String.Join(" ", wordsList).Split(' ');
            bool isFound = false;
           foreach (string word in words)
            {
                if (word.Equals(Search))
                {
                    isFound = true;
                    break;
                }
            }
           if (isFound)
            {
                Console.WriteLine($"{Search} is found");
            }
            else
            {
                Console.WriteLine($"{Search} is not found");
            }
        }
    }
}
