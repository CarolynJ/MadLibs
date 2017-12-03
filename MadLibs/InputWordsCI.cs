using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MadLibs
{
    public class InputWordsCI
    {
        

        public Dictionary<string, Word> PromptWordInput(Dictionary<string, Word> wordsNeeded)
        {
            foreach(KeyValuePair<string, Word> word in wordsNeeded)
            {
                string wordsprompt = Regex.Replace(word.Value.Prompt, "([A-Z])(?![A-Z])", " $1");
                wordsprompt = wordsprompt.Substring(0, 1).ToUpper() + wordsprompt.Substring(1);
               Console.WriteLine("Please enter a " + wordsprompt + ":");
               string newWord = Console.ReadLine();
               word.Value.Answer = newWord;
         
            }
            return wordsNeeded;
         

            
        }
        
    }
}
