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
        public string FileReader()
        {
            string storyInput = "";

            //string testStory = "New Text Document.txt";
            //string longerTest = "StoryFrame1.txt";
            //string filename;

            //(this commented out code is there for when there are multiple input files and  it lests the user select a story or input file)
            //Console.WriteLine("Which story would you like to use? enter 1 for: " + testStory + " enter 2 for:" + longerTest + " ?");
            //string storyChoice = Console.ReadLine();
            //if (storyChoice == "1")
            //{
            //    filename = "StoryFrame1.txt";
            //}
            //else if (storyChoice == "2")
            //{
            //    filename = "New Text Document.txt";
            //}
            //else
            //{
            //    filename = "New Text Document.txt";
            //}
        
            try
            {
                string filename = "New Text Document.txt";
                string directory = Environment.CurrentDirectory;
                string filePath = Path.Combine(directory, filename);

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string input = (sr.ReadLine());
                        storyInput += input;
                        Console.WriteLine(input);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file");
                Console.WriteLine(e.Message);
            }
            CreateListOfNeededWords wordList = new CreateListOfNeededWords();
            wordList.WordsNeeded(storyInput);
            return storyInput;
            

        }
        

   }  

}
