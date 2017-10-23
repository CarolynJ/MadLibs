﻿using System;
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

        public List<string> PromptWordInput(List<string> words)
        {
            foreach(string wordNeeded in words)
            {
               Console.WriteLine("Please enter a " + wordNeeded + ":");
               string newWord = Console.ReadLine();
               userInput.Add(newWord);
            }
            return userInput;
        }
        
    }
}
