using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meiosis.Engine
{
    public class LoremIpsumTextProvider : ILoremIpsumTextDictionary
    {

        private const string _alphabet = "qwertyuiopñlkjhgfdsazxcvbnm";

        private const int _wordLength = 10;

        public List<string> GetText(int wordsCount)
        {
            List<string> words = new List<string>();
            var random = new Random();

            for (int i = 0; i < wordsCount; i++)
            {

                words.Add(new string(Enumerable.Repeat(_alphabet, _wordLength)
                  .Select(s => s[random.Next(s.Length)]).ToArray()));
            }

            return words;
        }
    }
}
