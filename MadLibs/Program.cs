using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main()
        {
            StoryReader newStory = new StoryReader();
            newStory.FileReader();

            List<string> wordsNeeded = new List<string>();
            InputWordsCI requestWords = new InputWordsCI();
            requestWords.PromptWordInput(wordsNeeded);

            // call story reader but should it be a method inside of a story object?  
        }
    }

}


   