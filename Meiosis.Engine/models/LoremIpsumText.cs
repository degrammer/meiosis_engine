using System;
using System.Collections.Generic;

namespace Meiosis.Engine
{
    public class LoremIpsumText
    {

        private List<string> _words;

        public List<string> Words
        {
            get
            {
                _words = _words ?? new List<string>();
                return _words;
            }

            set
            {
                _words = value;
            }
        }


        public string AsParagraph()
        {
           return String.Join(" ", Words);
        }
    }
}