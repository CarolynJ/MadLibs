using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class CreateListOfNeededWords
    {
        public Dictionary<string, Word> WordsNeeded(string storyInput)
        {

            Dictionary<string, Word> wordsNeeded = new Dictionary<string, Word>();
            int keyNum = 0;
            string[] pieces = storyInput.Split(' ');
            foreach (string word in pieces)
            {
                if ((word.StartsWith("(")) && (word.EndsWith(")")))
                {
                    keyNum += 1;
                    string parsePrompt = keyNum + word.Substring(1, word.Length - 2);
                    ParsePrompt(parsePrompt, wordsNeeded);
                }
                else if (word.StartsWith("("))
                {
                    keyNum += 1;
                    string parsePrompt = keyNum+ word.Substring(1, word.Length - 3);
                    ParsePrompt(parsePrompt, wordsNeeded);
                }
            }
            return wordsNeeded;
        }

        private void ParsePrompt (string parsePrompt, Dictionary<string, Word> wordsNeeded)
        {
            string parsePromptClean = parsePrompt.Replace("(", "").Replace(")", "");
            string[] sections = parsePromptClean.Split(':');
            Word w = new Word();
            w.Answer = "";
            w.Prompt = sections[1];
            wordsNeeded.Add(parsePrompt, w);
        }

    }
}
