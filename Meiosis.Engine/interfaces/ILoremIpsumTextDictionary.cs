using System;
using System.Collections.Generic;

namespace Meiosis.Engine
{
    public interface ILoremIpsumTextDictionary
    {

        List<string> GetText(int wordsCount);

      
    }
}