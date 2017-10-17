using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class InputWordsCI
    {
        List<Word> words = new List<Word>();
        public void PromptWordInput()
        {
            foreach(Word wordNeeded in words)
            {
               // if (wordNeeded.WordType = 1)
                {
                    Console.WriteLine("Please enter a noun:");
                    string newWord = Console.ReadLine();
                   // words.Add(newword(1));

                }
                // if (wordNeeded.WordType = 20)
                {
                    Console.WriteLine("Please enter a verb in the past tense:");
                    string newWord = Console.ReadLine();
                    // words.Add(newword(1));

                }
                // if (wordNeeded.WordType = 20)
                {
                    Console.WriteLine("Please enter a verb in the past tense:");
                    string newWord = Console.ReadLine();
                    // words.Add(newword(1));

                }
            }
        }
        
    }
}
