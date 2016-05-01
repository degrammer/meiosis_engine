using System;
using System.Collections.Generic;

namespace Meiosis.Engine
{
    public interface LoremIpsumTextDictionaryProvider
    {

        List<string> GetWords(int wordsCount);
    }
}