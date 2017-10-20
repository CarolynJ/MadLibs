using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Word
    {
     
        Dictionary<int, string> wordTypes = new Dictionary<int, string>
        {
            {1, "name" },
            {2, "person" },
            {3, "place" },
            {4, "thing" },
            {5, "verb"},
            {6, "adjective"},
            {7, "topic" },
            {8, "frequency" },
            {9, "pronoun" }
        };
        
        string wordType;
        string inputText;

        public Word(string WordType)
        {
            this.wordType = WordType;
        }

    }
}
