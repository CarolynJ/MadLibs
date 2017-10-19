using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Story
    {
        string title;
        string storyText;
        List<Word> wordsNeeded;

        

        public Story()
        {
            string filename = "StoryFrame1.txt";
            string directory = Environment.CurrentDirectory;
            string filePath = Path.Combine(directory, filename);

            List<Word> words = new List<Word>();

           // (not sure if this is useful here or not)  StringBuilder sb = new StringBuilder();

            // will read in text from text file and call method to prepare the word list
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                       string input = (sr.ReadLine());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file");
                Console.WriteLine(e.Message);
            }
               
        }
        private static List<Word> PrepareWordList(string input)
        {
          
            string[] splits = input.Split('{');
            // I'm not sure what will end up in the array. I want to be able to evaluate the following letters

            foreach(string wordKind in splits)
            {
                // I would really like this loop to compare splits results to my dictionary of word types
                if((wordKind[0] == 'n') && (wordKind[1] == 'a'))
                {
                    words.Add(new Word(1));
                }
            }

            return words;
        }
    }
}
