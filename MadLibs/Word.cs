using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Word
    {
        int wordType;
        Dictionary<int, string> wordTypes = new Dictionary<int, string>()
        {
            // declare kvp for all the types of input
        };
        string text;


        public Word(int WordType)
        {
            this.wordType = WordType;
        }

    }
}
