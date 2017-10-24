using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MadLibs
{
    public class Story
    {
        public string StoryBuilder (string inputText, Dictionary<string, string> wordReplacement)
        {
           
            string outputStory = inputText;
            string cleanCompleteStory = "";
            foreach(KeyValuePair<string,string> kvp in wordReplacement)
            {
                 outputStory = outputStory.Replace(kvp.Key, kvp.Value);  
            }
            
            cleanCompleteStory = outputStory.Replace("(", "").Replace(")", "");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Here is the story you created:");
            Console.WriteLine();
            Console.WriteLine(cleanCompleteStory);
            Console.WriteLine();
            string wait = Console.ReadLine();
            return cleanCompleteStory;

            
        }
    }
}
