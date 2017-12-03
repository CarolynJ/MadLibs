using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    public class StoryReader
    {
        public void FileReader()
        {
            string storyInput = "";

            string testStory = "ShortTest.txt";
            string longerTest = "Test.txt";
            string Spooky = "SpookyMadLib.txt";
            string Open = "OpeningLines.txt";
            string filename;

            Console.WriteLine("Which story would you like to use?");
            Console.WriteLine("For a short test: enter 1");
            Console.WriteLine("For a longer test: enter 2");
            Console.WriteLine("For a Spooky MadLib: enter 3");
            Console.WriteLine("For opening lines to great novels: enter 4");
            
            string storyChoice = Console.ReadLine();
            if (storyChoice == "1")
            {
                filename = testStory;
            }
            else if (storyChoice == "2")
            {
                filename = longerTest;
            }
            else if (storyChoice == "3")
            {
                filename = Spooky;
            }
            else if (storyChoice == "4")
            {
                filename = Open;
            }
            else
            {
                filename = testStory;
            }

            try
            {
                
                string directory = Environment.CurrentDirectory;
                string filePath = Path.Combine(directory, filename);

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string input = (sr.ReadLine());
                        storyInput += input;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file");
                Console.WriteLine(e.Message);
            }
            CreateListOfNeededWords wordList = new CreateListOfNeededWords();
            Dictionary<string, Word> wordsNeeded =  wordList.WordsNeeded(storyInput);

            InputWordsCI requestWords = new InputWordsCI();
            wordsNeeded = requestWords.PromptWordInput(wordsNeeded);

            Story newStory = new Story();
            newStory.StoryBuilder(storyInput, wordsNeeded);

        }
        

   }  

}
