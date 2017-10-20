using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class InputWordsCI
    {
        // List<Word> words = new List<Word>();
        List<string> words = new List<string>();
        List<string> inputWords = new List<string>();

        public List<string> PromptWordInput()
        {
            foreach(string wordNeeded in words)
            {
               Console.WriteLine("Please enter a " + wordNeeded + ":");
               string newWord = Console.ReadLine();
               inputWords.Add(newWord);
            }
            return inputWords;
        }
        
    }
}
