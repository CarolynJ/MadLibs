using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class InputWordsCI
    {
        

        public Dictionary<string, Word> PromptWordInput(Dictionary<string, Word> wordsNeeded)
        {
            foreach(KeyValuePair<string, Word> word in wordsNeeded)
            {
               Console.WriteLine("Please enter a " + word.Value.Prompt + ":");
               string newWord = Console.ReadLine();
               word.Value.Answer = newWord;
         
            }
            return wordsNeeded;
         

            
        }
        
    }
}
