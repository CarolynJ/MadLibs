using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class StoryReader
    {
        static void FileReader()
        {

            //List<Word> words = new List<Word>();
            List<string> words = new List<string>();

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
                        Console.WriteLine(input);

                        string[] pieces = input.Split(' ');
                        foreach (string word in pieces)
                        {
                            if (word.StartsWith("("))
                            {
                                string wordType = word.Substring(1, word.Length - 2);
                                words.Add(wordType);
                            }
                        }
                        for (int i = 0; i < words.Count; i++)
                        {
                            Console.WriteLine(words[i]);
                        }

                        string greeting = Console.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file");
                Console.WriteLine(e.Message);
            }

        }
    }
}
