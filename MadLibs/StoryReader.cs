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
            // (not sure if this is useful here or not)  StringBuilder sb = new StringBuilder();

            try
            {
                string filename = "StoryFrame1.txt";
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
