using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class CreateListOfNeededWords
    {
        public List<string> WordsNeeded(string storyInput)
        {
            //List<Word> words = new List<Word>();
            List<string> wordsNeeded = new List<string>();

            string[] pieces = storyInput.Split(' ');
            foreach (string word in pieces)
            {
                if ((word.StartsWith("(")) && (word.EndsWith(")")))
                {
                    string wordType = word.Substring(1, word.Length - 2);
                    wordsNeeded.Add(wordType);
                }
                else if (word.StartsWith("("))
                {
                    string wordType = word.Substring(1, word.Length - 3);
                    wordsNeeded.Add(wordType);
                }
            }
            for (int i = 0; i < wordsNeeded.Count; i++)
            {
                Console.WriteLine(wordsNeeded[i]);
            }
            InputWordsCI requestWords = new InputWordsCI();
            requestWords.PromptWordInput(storyInput, wordsNeeded);
            return wordsNeeded;
        }
    }
}
