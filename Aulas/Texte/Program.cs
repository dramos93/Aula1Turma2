using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texte
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "The quick brown fox jumps over the lazy dog.";
            //string[] words = phrase.Split(' ');
            foreach (var word in phrase)
            {
                System.Console.WriteLine($"<{word}>");
            }
        }
    }
}
