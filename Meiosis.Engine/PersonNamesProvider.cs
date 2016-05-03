using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meiosis.Engine
{
    public class PersonNamesProvider : ILoremIpsumTextDictionary
    {

        private string[] _personNames = new string[] 
        {
            "bill gates",
            "steve jobs",
            "mark zuckerberg",
            "jeff bezos",
            "barack obama",
            "nelson mandela",
            "albert einstein"
        };


        public List<string> GetText(int wordsCount)
        {
            List<string> words = new List<string>();
            var random = new Random();

            for (int i = 0; i < wordsCount; i++)
            {
                words.Add(_personNames[random.Next(0, _personNames.Length)]);
            }

            return words;
        }
    }
}
