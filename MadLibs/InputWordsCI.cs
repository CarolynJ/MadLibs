using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class InputWordsCI
    {
        // List<Word> words = new List<Word>();
        List<string> words = new List<string>();
        List<string> userInput = new List<string>();
        Dictionary<string, string> wordReplacements = new Dictionary<string, string>();

        public List<string> PromptWordInput(string storyInput, List<string> words)
        {
            foreach(string wordNeeded in words)
            {
               Console.WriteLine("Please enter a " + wordNeeded + ":");
               string newWord = Console.ReadLine();
               userInput.Add(newWord);
                wordReplacements.Add(wordNeeded, newWord);

            }
            // this loop is to test that input is being saved. It should be deleted wh
            //for (int i = 0; i < userInput.Count; i++)
            //{
            //    Console.WriteLine(userInput[i]);
            //}

            Story newStory = new Story();
            newStory.StoryBuilder(storyInput, wordReplacements);
            return userInput;
        }
        
    }
}
