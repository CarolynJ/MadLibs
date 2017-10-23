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
            return storyInput;

        }
        public List<string> WordsNeeded(string storyInput)
        {
            //List<Word> words = new List<Word>();
            List<string> wordsNeeded = new List<string>();

            string[] pieces = storyInput.Split(' ');
            foreach (string word in pieces)
            {
                if ((word.StartsWith("(")) && (word.EndsWith(")")))
                {
                    string wordType = word.Substring(1, word.Length - 2);
                    wordsNeeded.Add(wordType);
                }
                else if (word.StartsWith("("))
                {
                    string wordType = word.Substring(1, word.Length - 3);
                    wordsNeeded.Add(wordType);
                }
            }
            for (int i = 0; i < wordsNeeded.Count; i++)
            {
                Console.WriteLine(wordsNeeded[i]);
            }

            return wordsNeeded;
        }

   }  

}
