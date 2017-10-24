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
        //string title;
        //string storyText;
        //List<Word> wordsNeeded;

        // (replacing this line with passing in a dictionary) public List<string> StoryBuilder(string inputText, List<string> userInput)

        public string StoryBuilder (string inputText, Dictionary<string, string> wordReplacement)
        {
           // List<string> outputStory = new List<string>();
            string outputStory = inputText;
            string cleanCompleteStory = "";
            foreach(KeyValuePair<string,string> kvp in wordReplacement)
            {
  
                 outputStory = outputStory.Replace(kvp.Key, kvp.Value);  
            }
            
            cleanCompleteStory = outputStory.Replace("(", "").Replace(")", "");

            Console.WriteLine("Here is the story you created:");
            Console.WriteLine(cleanCompleteStory);
            string wait = Console.ReadLine();
            return cleanCompleteStory;

            // below is my first try. the for loop inside the if doesn't work - it puts in the whole list.
            //string[] pieces = inputText.Split(' '); // Splits story text intp words so words in () can be replaced with userInput

            //foreach (string word in pieces)
            //{
            //    if ((word.StartsWith("(")) && (word.EndsWith(")")))
            //    {
            //        for (int i = 0; i <= userInput.Count - 1; i++)
            //        {

            //            outputStory.Add(userInput[i]);

            //        }
            //    }
            //    else
            //    {
            //        outputStory.Add(word);
            //    }
            //}
            //Console.WriteLine("Here is the story you created:");
            //for (int i = 0; i < outputStory.Count; i++)
            //{
            //    Console.Write(outputStory[i] + " ");
            //}
            //string wait = Console.ReadLine();
            //return outputStory;
        }
    }
}
