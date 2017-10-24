using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main()
        {
            StoryReader newStory = new StoryReader();
            newStory.FileReader();

            Console.WriteLine("Would you like to try another?");
            string reply = Console.ReadLine();

            if (reply.ToLower() == "y")
            {
                newStory.FileReader();
            }
            else
            {
                Console.WriteLine("I hope you return sometime soon.");
                string wait = Console.ReadLine();
            }
 
        }
    }

}


   