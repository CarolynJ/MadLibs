using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class Story
    {
        //string title;
        //string storyText;
        //List<Word> wordsNeeded;

        public List<string> StoryBuilder(string inputText, List<string> userInput)
        {
            List<string> outputStory = new List<string>();

            string[] pieces = inputText.Split(' '); // Splits story text intp words so words in () can be replaced with userInput

            foreach (string word in pieces)
            {
                if ((word.StartsWith("(")) && (word.EndsWith(")")))
                {
                    for (int i = 0; i <= userInput.Count - 1; i++)
                    {

                        outputStory.Add(userInput[i]);

                    }
                }
                else
                {
                    outputStory.Add(word);
                }
            }
            Console.WriteLine("Here is the story you created:");
            for (int i = 0; i < outputStory.Count; i++)
            {
                Console.Write(outputStory[i] + " ");
            }
            string wait = Console.ReadLine();
            return outputStory;
        }
    }
}
